using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas.Formularios;

namespace Vistas
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]

        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new frmGestionExpedientes());
        //}

        #region
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmConfiguracion configForm = new frmConfiguracion();
            frmRegistrar registrarForm = new frmRegistrar();
            frmPreguntas preguntasForm = new frmPreguntas();

            // 1. Verificar si existe configuración
            if (!Configuracion.ExisteConfiguracion())
            {
                if (configForm.ShowDialog() != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }
            }

            // 2. Verificar si ya existe al menos un usuario registrado
            if (!Configuracion.ExistePrimerUsuario())   // <-- deberías tener este método en tu modelo
            {
                if (registrarForm.ShowDialog() != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }
            }

            // 3. Verificar si ya existen preguntas de seguridad
            if (!frmPreguntas.ExistenPreguntas()) 
            {
                preguntasForm.Preguntas = 0; // modo agregar
                if (preguntasForm.ShowDialog() != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }
            }

            // 4. Todo correcto → abrir Login
            Application.Run(new frmLogin());
        }

        #endregion
    }
}





