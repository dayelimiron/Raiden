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
using TodoKiosco.BusinessLogic;

namespace TodoKiosco.Desktop
{
    public partial class frmAgregarCargo : Form
    {
        int id;
        public frmAgregarCargo()
        {
            InitializeComponent();
        }


        public frmAgregarCargo(Cargo entity)
        {
            InitializeComponent();
            id = entity.CargoId;

            textBoxCargo.Text = entity.Nombre;
        }

        private void frmAgregarCargo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }
    }
}
