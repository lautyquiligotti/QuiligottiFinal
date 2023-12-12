using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuiligottiFinal
{
    public partial class frmCargaProducto : Form
    {
        Productos producto = new Productos();
        DataTable tablaProductos;

        public frmCargaProducto()
        {
            InitializeComponent();
        }

        private void frmCargaProducto_Load(object sender, EventArgs e)
        {
            Productos producto = new Productos();
            tablaProductos = producto.GetData();
        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            DateTime fecha = Convert.ToDateTime(dtpFechaRegistro.Text);

            try
            {
                if (!txtIdProducto.Text.Equals("") && !txtNombreProductoCargar.Equals("") && !dtpFechaRegistro.Text.Equals(""))
                {
                    producto.GrabarProductos(txtIdProducto.Text, txtNombreProductoCargar.Text, fecha.ToString());
                    MessageBox.Show("PRODUCTO AGREGADO CON EXITO");
                }
                else
                {
                    MessageBox.Show("COMPLETE TODOS LOS CAMPOS");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("PRODUCTO AGREGADO CON EXITO");
            }
        }

        private void btnMostrarProducto_Click(object sender, EventArgs e)
        {
            dgvMostrarProductos.Rows.Clear();
            string productoBuscado = txtMostrarProducto.Text;

            if (txtMostrarProducto.Text != "")
            {
                foreach (DataRow producto in tablaProductos.Rows)
                {
                    if (Convert.ToString(producto["Nombre"]) == productoBuscado)
                    {
                        dgvMostrarProductos.Rows.Add(producto["Id"], producto["Nombre"], producto["FechaRegistro"]);
                    }

                }
            }
            else
            {
                MessageBox.Show("INGRESE NOMBRE DE PRODUCTO");
            }

        }
    }
}
