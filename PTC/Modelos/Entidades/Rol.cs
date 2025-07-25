﻿using Modelos.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Rol
    {
        private int IdRol;
        private string nombreRol;

        public int IdRol1 { get => IdRol; set => IdRol = value; }
        public string NombreRol { get => nombreRol; set => nombreRol = value; }

        public static DataTable CargarRol()
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaQuery = "select idRol, nombreRol from Rol";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }
    }
}
