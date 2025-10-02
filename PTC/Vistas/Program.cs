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
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Configuracion.ExisteConfiguracion())
            {
                frmConfiguracion configForm = new frmConfiguracion();
                if (configForm.ShowDialog() == DialogResult.OK)
                {
                    frmRegistrar registrarForm = new frmRegistrar();
                    if (registrarForm.ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(new frmLogin());
                    }
                    else if (registrarForm.DialogResult == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                // Si la aplicación se cerró previamente, mostrar frmRegistrar antes de frmLogin
                frmRegistrar registrarForm = new frmRegistrar();
                if (registrarForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new frmLogin());
                }
                else if (registrarForm.DialogResult == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}




