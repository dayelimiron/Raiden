using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoKiosco.BusinessLogic;
using TodoKiosco.Entities;

namespace TodoKiosco.Desktop
{
    public partial class frmTarjetas : Form
    {
        List<Denominacion> _listadoDenominaciones;
        
        public frmTarjetas()
        {
            InitializeComponent();
        }

        private void frmTarjetas_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            _listadoDenominaciones = DenominacionBL.Instance.SelectAll();

            dataGridView1.DataSource = _listadoDenominaciones;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTarjetasAgregar frm = new frmTarjetasAgregar();
            frm.ShowDialog();
            UpdateGrid();
        }
    }
}
