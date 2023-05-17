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
    public partial class frmConfig : Form
    {
        int id;
        public frmConfig()
        {
            InitializeComponent();
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            dataGridViewTelefonica.DataSource = TelefonicaBL.Instance.SelectAll();
            dataGridViewRoles.DataSource = RolBL.Instance.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBoxTelefonicaNombre.Text == "")
            {
                errorProvider1.SetError(textBoxTelefonicaNombre, "Campo obligatorio");
                return;
            }
           

            Telefonica entity = new Telefonica()
            {
                Nombre = textBoxTelefonicaNombre.Text.Trim(),               
            };

            if (id > 0)
            {
                entity.TelefonicaId = id;
                if (TelefonicaBL.Instance.Update(entity))
                {
                    MessageBox.Show("Se Modifico con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                if (TelefonicaBL.Instance.Insert(entity))
                {
                    MessageBox.Show("Se agrego con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            UpdateGrid();
            textBoxTelefonicaNombre.Text = "";
            id = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBoxRolesNombre.Text == "")
            {
                errorProvider1.SetError(textBoxRolesNombre, "Campo obligatorio");
                return;
            }


            Rol entity = new Rol()
            {
                Nombre = textBoxRolesNombre.Text.Trim(),
            };

            if (id > 0)
            {
                entity.RolId = id;
                if (RolBL.Instance.Update(entity))
                {
                    MessageBox.Show("Se Modifico con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                if (RolBL.Instance.Insert(entity))
                {
                    MessageBox.Show("Se agrego con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            UpdateGrid();
            textBoxRolesNombre.Text = "";
        }

        private void dataGridViewTelefonica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewTelefonica.Rows[e.RowIndex].Cells["Editar"].Selected)
            {
                id= int.Parse(dataGridViewTelefonica.Rows[e.RowIndex].Cells["TelefonicaId"].Value.ToString());
                string nombre = dataGridViewTelefonica.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

                textBoxTelefonicaNombre.Text = nombre;


            }

            if (dataGridViewTelefonica.Rows[e.RowIndex].Cells["Eliminar"].Selected)
            {
                int id = int.Parse(dataGridViewTelefonica.Rows[e.RowIndex].Cells["TelefonicaId"].Value.ToString());

                DialogResult dr = MessageBox.Show("Desea eliminar el registro actual?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    if (TelefonicaBL.Instance.Delete(id))
                    {
                        MessageBox.Show("Se Elimino con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

            }
        }
    }
}
