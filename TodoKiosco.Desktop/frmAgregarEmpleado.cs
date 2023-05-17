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
    public partial class frmAgregarEmpleado : Form
    {
        int id;
        public frmAgregarEmpleado()
        {
            InitializeComponent();
        }


        public frmAgregarEmpleado(Empleado entity)
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBoxNombre.Text == "")
            {
                errorProvider1.SetError(textBoxNombre, "Campo obligatorio");
                return;
            }
            if (textBoxApellido.Text == "")
            {
                errorProvider1.SetError(textBoxApellido, "Campo obligatorio");
                return;
            }

            if (textBoxDUI.Text == "")
            {
                errorProvider1.SetError(textBoxDUI, "Campo obligatorio");
                return;
            }

            if (textBoxTelefono.Text == "")
            {
                errorProvider1.SetError(textBoxTelefono, "Campo obligatorio");
                return;
            }

            Empleado entity = new Empleado()
            {
                Nombre = textBoxNombre.Text.Trim(),
                Apellido = textBoxApellido.Text.Trim(),
                DUI = textBoxDUI.Text.Trim(),
                Telefono = textBoxTelefono.Text.Trim(),
                FechaNacimiento = dateTimePickerNacimiento.Value,
                FechaIngreso = dateTimePickerIngreso.Value,
                Observaciones = textBoxObservaciones.Text.Trim(),
                Direccion = textBoxDireccion.Text.Trim(),
                CargoId = (int) comboBoxCargoId.SelectedValue
            };

            if (id > 0)
            {
                entity.CargoId = id;
                if (EmpleadoBL.Instance.Update(entity))
                {
                    MessageBox.Show("Se Modifico con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                if (EmpleadoBL.Instance.Insert(entity))
                {
                    MessageBox.Show("Se agrego con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            this.Close();
        }

        private void frmAgregarEmpleado_Load(object sender, EventArgs e)
        {
            UpdateCombo();
        }

        private void UpdateCombo()
        {
            comboBoxCargoId.DataSource = CargoBL.Instance.SelectAll();
            comboBoxCargoId.DisplayMember = "Nombre";
            comboBoxCargoId.ValueMember = "CargoId";
        }
    }
}
