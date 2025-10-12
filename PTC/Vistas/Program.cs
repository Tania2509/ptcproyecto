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
            Application.Run(new frmDashboardTrabajador());
        }

        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);

        //    if (!Configuracion.ExisteConfiguracion())
        //    {
        //        //No hay configuración
        //        frmConfiguracion configForm = new frmConfiguracion();
        //        if (configForm.ShowDialog() == DialogResult.OK)
        //        {
        //            frmRegistrar registrarForm = new frmRegistrar();
        //            if (registrarForm.ShowDialog() == DialogResult.OK)
        //            {
        //                Application.Run(new frmLogin());
        //            }
        //            else Application.Exit();
        //        }
        //        else Application.Exit();
        //    }
        //    else
        //    {
        //        // Ya hay configuración
        //        if (!Configuracion.ExistePrimerUsuario())
        //        {
        //            frmRegistrar registrarForm = new frmRegistrar();
        //            if (registrarForm.ShowDialog() == DialogResult.OK)
        //            {
        //                Application.Run(new frmLogin());
        //            }
        //            else Application.Exit();
        //        }
        //        else
        //        {
        //            Application.Run(new frmLogin());
        //        }
        //    }
        //}
    }

}





