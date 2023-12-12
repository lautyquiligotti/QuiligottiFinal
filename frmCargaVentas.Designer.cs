namespace QuiligottiFinal
{
    partial class frmCargaVentas
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVerFiltrado = new System.Windows.Forms.Button();
            this.txtFiltrarProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMostrarTodoVentas = new System.Windows.Forms.Button();
            this.dgvMostrarVentas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCargarVenta = new System.Windows.Forms.Button();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.txtNombreProductoVenta = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCantidadMayorA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarVentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnMostrarTodoVentas);
            this.groupBox2.Controls.Add(this.dgvMostrarVentas);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(426, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 438);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONSULTA";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtCantidadMayorA);
            this.groupBox3.Controls.Add(this.btnVerFiltrado);
            this.groupBox3.Controls.Add(this.txtFiltrarProducto);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(29, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 130);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FILTRAR POR";
            // 
            // btnVerFiltrado
            // 
            this.btnVerFiltrado.Location = new System.Drawing.Point(287, 39);
            this.btnVerFiltrado.Name = "btnVerFiltrado";
            this.btnVerFiltrado.Size = new System.Drawing.Size(99, 23);
            this.btnVerFiltrado.TabIndex = 14;
            this.btnVerFiltrado.Text = "FILTRAR";
            this.btnVerFiltrado.UseVisualStyleBackColor = true;
            this.btnVerFiltrado.Click += new System.EventHandler(this.btnVerFiltrado_Click);
            // 
            // txtFiltrarProducto
            // 
            this.txtFiltrarProducto.Location = new System.Drawing.Point(164, 71);
            this.txtFiltrarProducto.Name = "txtFiltrarProducto";
            this.txtFiltrarProducto.Size = new System.Drawing.Size(100, 20);
            this.txtFiltrarProducto.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "PRODUCTO VENDIDO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "CANTIDAD MAYOR A:";
            // 
            // btnMostrarTodoVentas
            // 
            this.btnMostrarTodoVentas.Location = new System.Drawing.Point(290, 190);
            this.btnMostrarTodoVentas.Name = "btnMostrarTodoVentas";
            this.btnMostrarTodoVentas.Size = new System.Drawing.Size(99, 23);
            this.btnMostrarTodoVentas.TabIndex = 9;
            this.btnMostrarTodoVentas.Text = "VER TODO";
            this.btnMostrarTodoVentas.UseVisualStyleBackColor = true;
            this.btnMostrarTodoVentas.Click += new System.EventHandler(this.btnMostrarTodoVentas_Click);
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
            this.dgvMostrarVentas.Location = new System.Drawing.Point(18, 219);
            this.dgvMostrarVentas.Name = "dgvMostrarVentas";
            this.dgvMostrarVentas.ReadOnly = true;
            this.dgvMostrarVentas.Size = new System.Drawing.Size(421, 188);
            this.dgvMostrarVentas.TabIndex = 8;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MOSTRAR PRODUCTOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.txtIdVenta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCargarVenta);
            this.groupBox1.Controls.Add(this.dtpFechaVenta);
            this.groupBox1.Controls.Add(this.txtNombreProductoVenta);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 392);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CANTIDAD";
            // 
            // btnCargarVenta
            // 
            this.btnCargarVenta.Location = new System.Drawing.Point(95, 272);
            this.btnCargarVenta.Name = "btnCargarVenta";
            this.btnCargarVenta.Size = new System.Drawing.Size(141, 23);
            this.btnCargarVenta.TabIndex = 7;
            this.btnCargarVenta.Text = "CARGAR VENTA";
            this.btnCargarVenta.UseVisualStyleBackColor = true;
            this.btnCargarVenta.Click += new System.EventHandler(this.btnCargarVenta_Click);
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVenta.Location = new System.Drawing.Point(95, 154);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(117, 20);
            this.dtpFechaVenta.TabIndex = 6;
            // 
            // txtNombreProductoVenta
            // 
            this.txtNombreProductoVenta.Location = new System.Drawing.Point(95, 109);
            this.txtNombreProductoVenta.Name = "txtNombreProductoVenta";
            this.txtNombreProductoVenta.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProductoVenta.TabIndex = 5;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(20, 160);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(42, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "FECHA";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 112);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(20, 68);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRAR VENTA";
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.Location = new System.Drawing.Point(64, 61);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.Size = new System.Drawing.Size(91, 20);
            this.txtIdVenta.TabIndex = 10;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(107, 202);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(129, 20);
            this.txtCantidad.TabIndex = 11;
            // 
            // txtCantidadMayorA
            // 
            this.txtCantidadMayorA.Location = new System.Drawing.Point(151, 26);
            this.txtCantidadMayorA.Name = "txtCantidadMayorA";
            this.txtCantidadMayorA.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadMayorA.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Respetar mayusculas y minusculas";
            // 
            // frmCargaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 503);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCargaVentas";
            this.Text = "VENTAS";
            this.Load += new System.EventHandler(this.frmCargaVentas_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarVentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnVerFiltrado;
        private System.Windows.Forms.TextBox txtFiltrarProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMostrarTodoVentas;
        private System.Windows.Forms.DataGridView dgvMostrarVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCargarVenta;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.TextBox txtNombreProductoVenta;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.TextBox txtCantidadMayorA;
        private System.Windows.Forms.Label label6;
    }
}