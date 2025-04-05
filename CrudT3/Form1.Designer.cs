namespace T3_Crud
{
    partial class Form1
    {
        /// <summary> 
        /// Variable necesaria para la compatibilidad del diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se están utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados deben ser eliminados; en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary> 
        /// Método necesario para admitir el diseño.
        /// No lo modifique con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            dgvProductos = new DataGridView();
            btnCrear = new Button();
            btnLeer = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            cmbProductos = new ComboBox();
            btnCerrar = new Button();  // Nuevo botón de cerrar
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(12, 12);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "ID Producto";
            txtId.Size = new Size(100, 27);
            txtId.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre Producto";
            txtNombre.Size = new Size(200, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(12, 64);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Precio Producto";
            txtPrecio.Size = new Size(100, 27);
            txtPrecio.TabIndex = 2;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 100);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(460, 200);
            dgvProductos.TabIndex = 3;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.SkyBlue;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(12, 310);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 30);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            btnCrear.MouseEnter += Button_MouseEnter;
            btnCrear.MouseLeave += Button_MouseLeave;
            // 
            // btnLeer
            // 
            btnLeer.BackColor = Color.LightGreen;
            btnLeer.FlatStyle = FlatStyle.Flat;
            btnLeer.ForeColor = Color.White;
            btnLeer.Location = new Point(93, 310);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(75, 30);
            btnLeer.TabIndex = 5;
            btnLeer.Text = "Leer";
            btnLeer.UseVisualStyleBackColor = false;
            btnLeer.Click += btnLeer_Click;
            btnLeer.MouseEnter += Button_MouseEnter;
            btnLeer.MouseLeave += Button_MouseLeave;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Orange;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(174, 310);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 30);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            btnActualizar.MouseEnter += Button_MouseEnter;
            btnActualizar.MouseLeave += Button_MouseLeave;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(255, 310);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 30);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            btnEliminar.MouseEnter += Button_MouseEnter;
            btnEliminar.MouseLeave += Button_MouseLeave;
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(255, 63);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(200, 28);
            cmbProductos.TabIndex = 8;
            cmbProductos.SelectedIndexChanged += cmbProductos_SelectedIndexChanged;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Crimson;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(350, 310);  // Posición del botón Cerrar
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 30);
            btnCerrar.TabIndex = 9;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;  // Evento Click para cerrar
            // 
            // Form1
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(484, 361);
            Controls.Add(btnCerrar);  // Agregar el botón Cerrar a los controles
            Controls.Add(cmbProductos);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnLeer);
            Controls.Add(btnCrear);
            Controls.Add(dgvProductos);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Name = "Form1";
            Text = "CRUD Productos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cmbProductos;  // Variable ComboBox agregada
        private System.Windows.Forms.Button btnCerrar;  // Nuevo botón Cerrar
    }
}
