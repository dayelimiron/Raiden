using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoKiosco.Entities;

namespace TodoKiosco.Desktop
{
    public partial class frmPrincipal : Form
    {
        Usuario _entity;
        public frmPrincipal()
        {
            InitializeComponent();
        }


        public frmPrincipal(Usuario entity)
        {
            InitializeComponent();

            _entity = entity;

            this.Text = "Bienvenido " + _entity.Email;
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargos frm = new frmCargos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados frm = new frmEmpleados();
            frm.MdiParent = this;
            frm.Show();
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfig frm = new frmConfig();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tarjetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTarjetas  frm = new frmTarjetas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas frm = new frmVentas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
