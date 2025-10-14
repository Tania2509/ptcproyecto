using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Entidades
{
    public class Producto
    {
        private int idProducto;
        private string nombrePro;
        private decimal precio;
        private int cantidad;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombrePro { get => nombrePro; set => nombrePro = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public static DataTable CargarProductos()
        {
            SqlConnection con = Conexion.Conexion.conectar();
            string comando = "select idProducto, nombrePro, precio from Producto";
            SqlDataAdapter ad = new SqlDataAdapter(comando, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public bool InsertarProducto()
        {
            using (SqlConnection con = Conexion.Conexion.conectar())
            {
                try
                {
                    string query = "INSERT INTO Producto (nombrePro, precio, cantidadPro) VALUES (@nombrePro, @precio, @cantidadPro)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@nombrePro", nombrePro);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@cantidadPro", cantidad);

                    int filas = cmd.ExecuteNonQuery();

                    // Cerrar explícitamente
                    con.Close();

                    return filas > 0;
                }
                catch (Exception ex)
                {
                    // Cerrar en caso de error también
                    if (con.State == ConnectionState.Open)
                        con.Close();

                    MessageBox.Show("Error en insertar producto: " + ex.Message);
                    return false;
                }
            }
        }

        public bool ActualizarProducto()
        {
            using (SqlConnection con = Conexion.Conexion.conectar())
            {
                try
                {
                    string query = "UPDATE Producto SET nombrePro = @nombrePro, precio = @precio WHERE idProducto = @idProducto";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    cmd.Parameters.AddWithValue("@nombrePro", nombrePro);
                    cmd.Parameters.AddWithValue("@precio", precio);

                    // La conexión YA está abierta por el método conectar(), NO necesitas con.Open()
                    int filas = cmd.ExecuteNonQuery();

                    // Cerrar explícitamente antes de que termine el using
                    con.Close();

                    return filas > 0;
                }
                catch (Exception ex)
                {
                    // Cerrar en caso de error también
                    if (con.State == ConnectionState.Open)
                        con.Close();

                    Console.WriteLine("Error al actualizar: " + ex.Message);
                    return false;
                }
            }
        }


        public bool EliminarProducto(int idProducto)
        {
            using (SqlConnection con = Conexion.Conexion.conectar())
            {
                try
                {
                    string query = "DELETE FROM Producto WHERE idProducto = @idProducto";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);

                    // La conexión YA está abierta por el método conectar(), NO necesitas con.Open()
                    int filas = cmd.ExecuteNonQuery();

                    // Cerrar explícitamente antes de que termine el using
                    con.Close();

                    return filas > 0;
                }
                catch (Exception ex)
                {
                    // Cerrar en caso de error también
                    if (con.State == ConnectionState.Open)
                        con.Close();

                    MessageBox.Show("Error en EliminarProducto: " + ex.Message);
                    return false;
                }
            }
        }

        public DataTable MostrarProductos()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection con = Conexion.Conexion.conectar())
            {
                string query = "SELECT idProducto as Producto, nombrePro as [Nombre del producto], precio as Precio FROM Producto";
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                try
                {
                    da.Fill(tabla);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al mostrar productos: " + ex.Message);
                }
            }

            return tabla;
        }
    }
}
