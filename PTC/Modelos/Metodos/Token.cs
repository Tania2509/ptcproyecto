using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Metodos
{
    public class Token
    {
        private static int usuarioID;
        private static string codigo;
        private static DateTime expira;

        public static int UsuarioID { get => usuarioID; set => usuarioID = value; }
        public static string Codigo { get => codigo; set => codigo = value; }
        public static DateTime Expira { get => expira; set => expira = value; }

        public static bool TokenValido(string tokenIngresado)
        {
            if (Codigo != null && DateTime.Now <= Expira)
            {
                return tokenIngresado == Codigo;
            }
            else
            {
                LimpiarToken(); // Limpiar automáticamente si ha expirado
                return false;
            }
        }

        public static void LimpiarToken()
        {
            UsuarioID = 0;
            Codigo = null;
            Expira = DateTime.MinValue;
        }


    }
}
