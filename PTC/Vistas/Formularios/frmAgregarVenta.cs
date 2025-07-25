using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Entidades;
using Vistas.Formularios;

namespace Vistas.Formularios
{
    public partial class frmAgregarVenta : Form
    {




        public frmAgregarVenta(frmGestionVenta formpadre)
        {
            InitializeComponent();
            frmGestionVenta = formpadre;
        }

        private frmGestionVenta frmGestionVenta;

        public void btnCrearArt_Click(object sender, EventArgs e)
        {

            Modelos.Entidades.Venta V = new Venta();
            V.Cantidad = Convert.ToInt32(txtUnidadesActuales.Text);
            V.Precio = Convert.ToDouble(txtPrecioProducto.Text);
            V.NombreVen = txtNombreProducto.Text;
            V.InsetarProductos();

            frmGestionVenta.MostrarProductos();

            this.Close();
        }
    }

    
}
