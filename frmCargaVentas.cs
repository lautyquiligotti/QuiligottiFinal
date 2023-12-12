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
    public partial class frmCargaVentas : Form
    {
        Ventas ventas = new Ventas();
        DataTable tablaVentas;

        public frmCargaVentas()
        {
            InitializeComponent();
        }

        private void frmCargaVentas_Load(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            tablaVentas = ventas.GetData();
        }

        private void btnCargarVenta_Click(object sender, EventArgs e)
        {
            DateTime fecha = Convert.ToDateTime(dtpFechaVenta.Text);

            try
            {
                if (!txtIdVenta.Text.Equals("") && !txtNombreProductoVenta.Text.Equals("") && !txtCantidad.Text.Equals("") && !dtpFechaVenta.Text.Equals(""))
                {
                    ventas.GrabarVenta(txtIdVenta.Text, fecha.ToString(), txtNombreProductoVenta.Text, txtCantidad.Text);
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

        private void btnMostrarTodoVentas_Click(object sender, EventArgs e)
        {
            dgvMostrarVentas.Rows.Clear();

            foreach (DataRow ventas in tablaVentas.Rows)
            {
                dgvMostrarVentas.Rows.Add(ventas["Id"], ventas["FechaVenta"], ventas["Producto"], ventas["Cantidad"]);
            }
        }

        private void btnVerFiltrado_Click(object sender, EventArgs e)
        {
            dgvMostrarVentas.Rows.Clear();

            if (!txtCantidadMayorA.Text.Equals("") && !txtFiltrarProducto.Text.Equals(""))
            {
                int filtrarCantidad = int.Parse(txtCantidadMayorA.Text);
                string filtarProducto = txtFiltrarProducto.Text;

                foreach (DataRow ventas in tablaVentas.Rows)
                {
                    if (Convert.ToInt32(ventas["Cantidad"]) >= filtrarCantidad && Convert.ToString(ventas["Producto"]) == filtarProducto )
                    {
                        dgvMostrarVentas.Rows.Add(ventas["Id"], ventas["FechaVenta"], ventas["Producto"], ventas["Cantidad"]);
                    }

                }
            }
            else
            {
                MessageBox.Show("COMPLETE TODOS LOS CAMPOS");
            }

        }
    }
}
