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
    public partial class frmImpresion : Form
    {
        Productos producto = new Productos();
        DataTable tablaProductos;
        Ventas ventas = new Ventas();
        DataTable tablaVentas;

        public frmImpresion()
        {
            InitializeComponent();
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            dgvMostrarProductos.Rows.Clear();

            foreach (DataRow producto in tablaProductos.Rows)
            {
                dgvMostrarProductos.Rows.Add(producto["Id"], producto["Nombre"], producto["FechaRegistro"]);
            }
        }

        private void btnVerVentas_Click(object sender, EventArgs e)
        {
            dgvMostrarVentas.Rows.Clear();

            foreach (DataRow ventas in tablaVentas.Rows)
            {
                dgvMostrarVentas.Rows.Add(ventas["Id"], ventas["FechaVenta"], ventas["Producto"], ventas["Cantidad"]);
            }
        }

        private void frmImpresion_Load(object sender, EventArgs e)
        {
            Productos producto = new Productos();
            tablaProductos = producto.GetData();
            Ventas ventas = new Ventas();
            tablaVentas = ventas.GetData();
        }
    }
}
