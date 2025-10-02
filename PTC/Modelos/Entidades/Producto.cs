using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Producto
    {

        public static DataTable CargarProductos()
        {
            SqlConnection con = Conexion.Conexion.conectar();
            string comando = "select idProducto, nombrePro, precio from Producto";
            SqlDataAdapter ad = new SqlDataAdapter(comando, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
    }
}
