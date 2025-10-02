using Modelos.Entidades;
using Modelos.Metodos;
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

        private void frmGestionInventario_Load(object sender, EventArgs e)
        {
            MostrarProductos();
            CargarProductos();
            cbProducto.SelectedIndexChanged += cbProducto_SelectedIndexChanged;
            txtPrecioProducto.Text = " ";
        }

        #region 

        private void CargarProductos()
        {
            cbProducto.DataSource = null;
            cbProducto.DataSource = Producto.CargarProductos();
            cbProducto.DisplayMember = "nombrePro";
            cbProducto.ValueMember = "idProducto";
            cbProducto.SelectedIndex = -1;
        }

        #endregion

        private void LimpiarCampos()
        {
            cbProducto.SelectedIndex = -1;
            txtPrecioProducto.Text = "";
            txtUnidadesActuales.Text = "";
        }

        public void MostrarProductos()
        {
            dgvMostrarPro.DataSource = null;
            dgvMostrarPro.DataSource = Modelos.Entidades.Venta.CargarProductos();
        }

        private void dgvMostrarPro_DoubleClick(object sender, EventArgs e)
        {
            cbProducto.Text = dgvMostrarPro.CurrentRow.Cells["Producto"].Value.ToString();
            txtPrecioProducto.Text = dgvMostrarPro.CurrentRow.Cells["Precio"].Value.ToString();
            txtUnidadesActuales.Text = dgvMostrarPro.CurrentRow.Cells["Cantidad Vendida"].Value.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMostrarPro.DataSource = null;
                dgvMostrarPro.DataSource = Venta.Buscar(txtBuscar.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Textbox

        Validaciones V = new Validaciones();

        private void txtUnidadesActuales_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.Numeros(sender, e);
        }

        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(txtUnidadesActuales.Text) ||
                cbProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Modelos.Entidades.Venta V = new Venta();
            V.Cantidad = Convert.ToInt32(txtUnidadesActuales.Text);
            V.IdProducto = Convert.ToInt32(cbProducto.SelectedValue);
            V.InsetarProductos();

            MostrarProductos();
            LimpiarCampos();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUnidadesActuales.Text) ||
                 cbProducto.SelectedIndex == -1)

            {
                MessageBox.Show("No dejes campos vacios", "Campos obligatorios");
                return;
            }

            Venta V = new Venta();
            V.Cantidad = Convert.ToInt32(txtUnidadesActuales.Text);
            V.IdProducto = Convert.ToInt32(cbProducto.SelectedValue);
            V.IdVenta = Convert.ToInt32(dgvMostrarPro.CurrentRow.Cells[0].Value);

            if (V.ActualizarVenta() == true)
            {
                MostrarProductos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al actualizar la venta.", "Error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
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

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProducto.SelectedIndex != -1)
            {
                if (cbProducto.SelectedValue != null)
                {
                    // Buscar el precio en el DataTable
                    DataRowView selectedRow = (DataRowView)cbProducto.SelectedItem;
                    decimal precio = Convert.ToDecimal(selectedRow["Precio"]);
                    txtPrecioProducto.Text = precio.ToString("C2");
                }
            }
        }
    }
}
