namespace QuiligottiFinal
{
    partial class frmImpresion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMostrarVentas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMostrarProductos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerProductos = new System.Windows.Forms.Button();
            this.btnVerVentas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrarVentas
            // 
            this.dgvMostrarVentas.AllowUserToAddRows = false;
            this.dgvMostrarVentas.AllowUserToDeleteRows = false;
            this.dgvMostrarVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FechaVenta,
            this.Producto,
            this.Cantidad});
            this.dgvMostrarVentas.Location = new System.Drawing.Point(449, 121);
            this.dgvMostrarVentas.Name = "dgvMostrarVentas";
            this.dgvMostrarVentas.ReadOnly = true;
            this.dgvMostrarVentas.Size = new System.Drawing.Size(365, 188);
            this.dgvMostrarVentas.TabIndex = 9;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // FechaVenta
            // 
            this.FechaVenta.HeaderText = "Fecha";
            this.FechaVenta.Name = "FechaVenta";
            this.FechaVenta.ReadOnly = true;
            this.FechaVenta.Width = 70;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cant.";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 50;
            // 
            // dgvMostrarProductos
            // 
            this.dgvMostrarProductos.AllowUserToAddRows = false;
            this.dgvMostrarProductos.AllowUserToDeleteRows = false;
            this.dgvMostrarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Nombre,
            this.FechaRegistro});
            this.dgvMostrarProductos.Location = new System.Drawing.Point(12, 121);
            this.dgvMostrarProductos.Name = "dgvMostrarProductos";
            this.dgvMostrarProductos.ReadOnly = true;
            this.dgvMostrarProductos.Size = new System.Drawing.Size(396, 188);
            this.dgvMostrarProductos.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "FORMULARIO DE IMPRESION";
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.Location = new System.Drawing.Point(114, 336);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(142, 39);
            this.btnVerProductos.TabIndex = 12;
            this.btnVerProductos.Text = "VER PRODUCTOS";
            this.btnVerProductos.UseVisualStyleBackColor = true;
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click);
            // 
            // btnVerVentas
            // 
            this.btnVerVentas.Location = new System.Drawing.Point(577, 336);
            this.btnVerVentas.Name = "btnVerVentas";
            this.btnVerVentas.Size = new System.Drawing.Size(142, 39);
            this.btnVerVentas.TabIndex = 13;
            this.btnVerVentas.Text = "VER VENTAS";
            this.btnVerVentas.UseVisualStyleBackColor = true;
            this.btnVerVentas.Click += new System.EventHandler(this.btnVerVentas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "PRODUCTOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(573, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "VENTAS";
            // 
            // frmImpresion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVerVentas);
            this.Controls.Add(this.btnVerProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMostrarProductos);
            this.Controls.Add(this.dgvMostrarVentas);
            this.Name = "frmImpresion";
            this.Text = "IMPRESION";
            this.Load += new System.EventHandler(this.frmImpresion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrarVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridView dgvMostrarProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerProductos;
        private System.Windows.Forms.Button btnVerVentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}