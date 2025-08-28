using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Entidades
{
    public class Usuario
    {
        private int idUsuario;
        private string nombreU;
        private string apellidoU;
        private DateTime fechaNacimientoU;
        private string duiU;
        private string telefonoU;
        private string correo;
        private int id_Rol;
        private int id_Especialidad;
        private int id_venta;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreU { get => nombreU; set => nombreU = value; }
        public string ApellidoU { get => apellidoU; set => apellidoU = value; }
        public DateTime FechaNacimientoU { get => fechaNacimientoU; set => fechaNacimientoU = value; }
        public string DuiU { get => duiU; set => duiU = value; }
        public string TelefonoU { get => telefonoU; set => telefonoU = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Id_Rol { get => id_Rol; set => id_Rol = value; }
        public int Id_Especialidad { get => id_Especialidad; set => id_Especialidad = value; }
        public int Id_venta { get => id_venta; set => id_venta = value; }

        public static DataTable CargarUsuarios(string Trabajador)
        {
            SqlConnection con = Conexion.Conexion.conectar();
            string comando = "select * from CrearUsuario";
            SqlDataAdapter ad = new SqlDataAdapter(comando, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }

        public bool InsetarUsuarios()
        {
            SqlConnection con = Conexion.Conexion.conectar();

            string comando = "Insert into Usuario(nombreUsu, apellidoUsu, fechaNaciUsu, duiUsu, telefonoUsu, correoUsu, id_Rol, id_Especialidad, id_venta) " +
                     "values(@nombreUsu, @apellidoUsu, @fechaNaciUsu, @duiUsu, @telefonoUsu, @correoUsu, @id_Rol, @id_Especialidad, @id_venta);";

            SqlCommand cmd = new SqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nombreUsu", NombreU);
            cmd.Parameters.AddWithValue("@apellidoUsu", ApellidoU);
            cmd.Parameters.AddWithValue("@fechaNaciUsu", FechaNacimientoU);
            cmd.Parameters.AddWithValue("@duiUsu", DuiU);
            cmd.Parameters.AddWithValue("@telefonoUsu", TelefonoU);
            cmd.Parameters.AddWithValue("@correoUsu", $"{DuiU}@gmail.com");
            cmd.Parameters.AddWithValue("@id_Rol", id_Rol);
            cmd.Parameters.AddWithValue("@id_Especialidad", Id_Especialidad);
            cmd.Parameters.AddWithValue("@id_venta", DBNull.Value);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool eliminarTrabajador(int id)
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaDelete = "Delete from Usuario where idUsuario = @id;";
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
