using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuPrincipal
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos frmProductos = new Productos();
            frmProductos.MdiParent = this;
            frmProductos.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes frmclientes = new Clientes();
            frmclientes.MdiParent = this;
            frmclientes.Show();
        }

        private void presupuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presupuestos Frmpresupuestos = new Presupuestos();
            //Frmpresupuestos.MdiParent = this;
            Frmpresupuestos.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prooveedores frmprooveedores = new Prooveedores();
            frmprooveedores.MdiParent = this;
            frmprooveedores.Show();
        }

        private void presupuesto2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //presupuesto2 presu = new presupuesto2();
            //presu.MdiParent = this;
            //presu.Show();
        }
    }
}

