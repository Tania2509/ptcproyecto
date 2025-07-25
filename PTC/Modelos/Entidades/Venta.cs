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
        private string nombreVen;
        private double precio;
        private int cantidad;

        public int IdVenta { get => idVenta; set => idVenta = value; }
        public string NombreVen { get => nombreVen; set => nombreVen = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public static DataTable CargarProductos()
        {
            SqlConnection con = Conexion.Conexion.conectar();
            string comando = "select * from Venta;";
            SqlDataAdapter ad = new SqlDataAdapter(comando, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }

        public bool InsetarProductos()
        {
            SqlConnection con = Conexion.Conexion.conectar();

            string comando = "Insert into Venta(nombreVen, precio, cantidad)" + "values(@nombreVen, @precio, @cantidad);";

            SqlCommand cmd = new SqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nombreVen", NombreVen);
            cmd.Parameters.AddWithValue("@precio", Precio);
            cmd.Parameters.AddWithValue("@cantidad", Cantidad);


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
    }
}
