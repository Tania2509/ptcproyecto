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
    public partial class frmGestionInventario : Form
    {
        public frmGestionInventario()
        {
            InitializeComponent();
        }
        public void LimpiarCampos()
        {
            // Limpiar campos de texto
            txtNombre.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtCantidad.Text = string.Empty;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }
            else if (decimal.Parse(txtPrecio.Text) < 0)
            {
                MessageBox.Show("El precio debe ser un número válido.");
                return;
            }
            try
            {
                Producto P = new Producto();

                P.NombrePro = txtNombre.Text.Trim();
                P.Precio = decimal.Parse(txtPrecio.Text.Trim());
                P.Cantidad = int.Parse(txtCantidad.Text.Trim());

                bool exito = P.InsertarProducto();

                if (exito)
                {
                    MessageBox.Show("Producto insertado correctamente.");
                    dgvProductos.DataSource = P.MostrarProductos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el producto. Revisa la conexión o los datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("No dejes campos vacios", "Campos obligatorios");
                return;
            }

            Producto E = new Producto();
            E.NombrePro = txtNombre.Text;
            E.Precio = decimal.Parse(txtPrecio.Text);

            if (E.ActualizarProducto() == true)
            {
                E.MostrarProductos();
                LimpiarCampos();
                dgvProductos.DataSource = E.MostrarProductos();
            }
            else
            {
                MessageBox.Show("Error al actualizar el trabajador.", "Error");
            }
        }

        private void AjustarColumnasDataGrid()
        {
            dgvProductos.Columns[1].Width = 200;
            dgvProductos.Columns[2].Width = 102;
        }

        private void frmGestionInventario_Load(object sender, EventArgs e)
        {
            Producto P = new Producto();
            dgvProductos.DataSource = P.MostrarProductos();
            dgvProductos.Columns["Producto"].Visible = false;
            AjustarColumnasDataGrid();
        }

        private void dgvProductos_DoubleClick(object sender, EventArgs e)
        {
            txtNombre.Text = dgvProductos.CurrentRow.Cells["Nombre del producto"].Value.ToString();
            txtPrecio.Text = dgvProductos.CurrentRow.Cells["Precio"].Value.ToString();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un Producto para eliminar.");
                return;
            }

            int idUsuario = Convert.ToInt32(dgvProductos.CurrentRow.Cells["Producto"].Value);
            string nombreProducto = dgvProductos.CurrentRow.Cells["Nombre del producto"].Value.ToString();

            Producto u = new Producto();

            // Confirmar eliminación
            DialogResult result = MessageBox.Show(
                $"¿Está seguro de eliminar al usuario: {nombreProducto}?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                u.EliminarProducto(idUsuario);

                // Refrescar la lista de usuarios
                dgvProductos.DataSource = u.MostrarProductos();

            }
        }

        #region

        Validaciones V = new Validaciones();
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.Letras(sender, e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.Numeros(sender, e);
        }

        #endregion


    }
}
