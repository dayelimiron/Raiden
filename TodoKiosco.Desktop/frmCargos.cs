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
    public partial class frmCargos : Form
    {
        public frmCargos()
        {
            InitializeComponent();
        }

        private void frmCargos_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void UpdateGrid()
        {            
            dataGridView1.DataSource = CargoBL.Instance.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAgregarCargo frm = new frmAgregarCargo();
            frm.ShowDialog();
            UpdateGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells["Editar"].Selected)
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["CargoId"].Value.ToString());
                string nombre = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

                Cargo entity = new Cargo()
                {
                    CargoId = id,
                    Nombre = nombre
                };

                //Editar
                frmAgregarCargo frm = new frmAgregarCargo(entity);
                frm.ShowDialog();
                UpdateGrid();


            }

            if (dataGridView1.Rows[e.RowIndex].Cells["Eliminar"].Selected)
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["CargoId"].Value.ToString());

                DialogResult dr = MessageBox.Show("Desea eliminar el registro actual?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if(dr == DialogResult.Yes)
                {
                    if (CargoBL.Instance.Delete(id))
                    {
                        MessageBox.Show("Se Elimino con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
