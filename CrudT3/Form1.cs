using System;
using System.Drawing;  // Necesario para el manejo de colores
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

            // Asignar eventos de mouse
            btnCrear.MouseEnter += Button_MouseEnter;
            btnCrear.MouseLeave += Button_MouseLeave;

            btnLeer.MouseEnter += Button_MouseEnter;
            btnLeer.MouseLeave += Button_MouseLeave;

            btnActualizar.MouseEnter += Button_MouseEnter;
            btnActualizar.MouseLeave += Button_MouseLeave;

            btnEliminar.MouseEnter += Button_MouseEnter;
            btnEliminar.MouseLeave += Button_MouseLeave;

            btnCerrar.MouseEnter += Button_MouseEnter;
            btnCerrar.MouseLeave += Button_MouseLeave;
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            this.Close();
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

        // Métodos para manejar los eventos MouseEnter y MouseLeave
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.BackColor = Color.LightGray;  // Cambiar el color de fondo cuando el ratón entra
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                // Restaurar color original
                if (button == btnCrear) button.BackColor = Color.SkyBlue;
                if (button == btnLeer) button.BackColor = Color.LightGreen;
                if (button == btnActualizar) button.BackColor = Color.Orange;
                if (button == btnEliminar) button.BackColor = Color.Crimson;
                if (button == btnCerrar) button.BackColor = Color.Gray;  // Color original para btnCerrar
            }
        }
    }
}
