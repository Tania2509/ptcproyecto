using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class EstadoDiente
    {

        public DataTable ObtenerEstados()
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaQuery = "SELECT idEstado, nombre_estado FROM EstadoDiente";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }

        
    }
}
