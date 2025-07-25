using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Expediente
    {
        private int idExpediente;
        private string enfermedades;
        private string alergias;
        private int pacienteId;

        public int IdExpediente { get => idExpediente; set => idExpediente = value; }
        public string Enfermedades { get => enfermedades; set => enfermedades = value; }
        public string Alergias { get => alergias; set => alergias = value; }
        public int PacienteId { get => pacienteId; set => pacienteId = value; }

        #region Combobox
        public static DataTable CargarAlergia()
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaQuery = "select idExpediente, alergias from Expediente";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }

        public static DataTable CargarEnfermedades()
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaQuery = "select idExpediente, enfermedades from Expediente";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }

        #endregion
    }
}