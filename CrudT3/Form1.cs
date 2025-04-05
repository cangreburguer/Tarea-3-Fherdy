using System;
using System.Windows.Forms;
using T3_Crud.Logic;
using T3_Crud.Models;

namespace T3_Crud
{
    public partial class Form1 : Form
    {
        private Crud crud;

        public Form1()
        {
            InitializeComponent();
            crud = new Crud();
            CargarProductosComboBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = null;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            if (double.TryParse(txtPrecio.Text, out double precio))
            {
                crud.Crear(nombre, precio);
                MessageBox.Show("Producto creado exitosamente.");
                LimpiarCampos();
                ActualizarDataGridView();
                CargarProductosComboBox();
            }
            else
            {
                MessageBox.Show("El precio no es válido.");
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id) && double.TryParse(txtPrecio.Text, out double precio))
            {
                string nombre = txtNombre.Text;
                if (crud.Actualizar(id, nombre, precio))
                {
                    MessageBox.Show("Producto actualizado.");
                    LimpiarCampos();
                    ActualizarDataGridView();
                    CargarProductosComboBox();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("ID o precio no válidos.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id))
            {
                if (crud.Eliminar(id))
                {
                    MessageBox.Show("Producto eliminado.");
                    LimpiarCampos();
                    ActualizarDataGridView();
                    CargarProductosComboBox();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("ID no válido.");
            }
        }

        private void ActualizarDataGridView()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = crud.Leer();
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
        }

        private void CargarProductosComboBox()
        {
            cmbProductos.Items.Clear();
            foreach (var producto in crud.Leer())
            {
                cmbProductos.Items.Add(producto);
            }
            if (cmbProductos.Items.Count > 0)
                cmbProductos.SelectedIndex = 0;
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedItem is Producto producto)
            {
                txtId.Text = producto.Id.ToString();
                txtNombre.Text = producto.Nombre;
                txtPrecio.Text = producto.Precio.ToString("0.00");
            }
        }
    }
}