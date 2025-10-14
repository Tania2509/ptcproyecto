using Modelos.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Entidades
{
    public class Venta
    {
        private int idVenta;
        private int cantidad;
        private int idProducto;
        private int idUsuario;

        public int IdVenta { get => idVenta; set => idVenta = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }

        public static DataTable CargarProductos()
        {
            SqlConnection con = Conexion.Conexion.conectar();
            string comando = "select *from Ventas";
            SqlDataAdapter ad = new SqlDataAdapter(comando, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }

        public static class Sesion
        {
            public static int IdUsuario { get; set; }
        }

        public bool InsetarProductos()
        {
            SqlConnection con = Conexion.Conexion.conectar();

            string comando = "INSERT INTO Venta(cantidad, id_Producto, id_Usuario) " +
                 "VALUES(@cantidad, @id_Producto, @id_Usuario)" +
                 "UPDATE Producto SET cantidadPro = cantidadPro - @cantidadVendida " +
                 "WHERE idProducto = @id_Producto";
            SqlCommand cmd = new SqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@cantidad", Cantidad);
            cmd.Parameters.AddWithValue("@id_Producto", IdProducto);
            cmd.Parameters.AddWithValue("@id_Usuario", IdUsuario);


            return cmd.ExecuteNonQuery() > 0;
        }

        public bool eliminarProducto(int id)
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaDelete = "Delete from Venta where idVenta = @id;";
            SqlCommand delete = new SqlCommand(consultaDelete, conexion);
            delete.Parameters.AddWithValue("@id", id);
            if (delete.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Eliminando Registros", "Exito al eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ActualizarVenta()
        {
            SqlConnection con = Conexion.Conexion.conectar();
            string comando = "UPDATE Venta SET id_Producto = @id_Producto, cantidad = @cantidad WHERE idVenta=@idVenta;";
            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@idVenta", IdVenta);
            cmd.Parameters.AddWithValue("@id_Producto", IdProducto);
            cmd.Parameters.AddWithValue("@cantidad", Cantidad);

            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static DataTable Buscar(string termino)
        {
            SqlConnection con = Conexion.Conexion.conectar();
            string comando = $"select *from Ventas where producto like '%{termino}%';";
            SqlDataAdapter ad = new SqlDataAdapter(comando, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;

        }
    }
}
