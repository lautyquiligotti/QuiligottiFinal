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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmCargaProducto ventana = new frmCargaProducto();
            ventana.ShowDialog();
            this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmCargaVentas ventana = new frmCargaVentas();
            ventana.ShowDialog();
            this.Hide();
        }

        private void btnImpresion_Click(object sender, EventArgs e)
        {
            frmImpresion ventana = new frmImpresion();
            ventana.ShowDialog();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
