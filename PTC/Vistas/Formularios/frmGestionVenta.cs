using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmGestionVenta : Form
    {
        public frmGestionVenta()
        {
            InitializeComponent();
        }


        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            frmAgregarVenta ventana = new frmAgregarVenta(this);
            ventana.Visible = true;
            ventana.Show(); 
        }

        private void frmGestionInventario_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        

        public void MostrarProductos()
        {
            dgvMostrarPro.DataSource = null;
            dgvMostrarPro.DataSource = Modelos.Entidades.Venta.CargarProductos();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            Venta curso = new Venta();
            //Creo una variable para capturar el registo o fila del datagrid
            int id = int.Parse(dgvMostrarPro.CurrentRow.Cells[0].Value.ToString());
            if (curso.eliminarProducto(id) == true)
            {
                MessageBox.Show("Registro eliminado correctamente", "Exito");
                MostrarProductos();
            }
            else
            {
                MessageBox.Show("Se produjo un error", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
    }
    }
}
