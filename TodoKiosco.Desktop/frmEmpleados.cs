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
    public partial class frmEmpleados : Form
    {
        List<Empleado> _listado;
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAgregarEmpleado frm = new frmAgregarEmpleado();
            frm.ShowDialog();
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            _listado = EmpleadoBL.Instance.SelectAll();
            dataGridView1.DataSource = _listado;
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
