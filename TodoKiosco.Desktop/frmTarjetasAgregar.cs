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
    public partial class frmTarjetasAgregar : Form
    {
        string id;
        List<Telefonica> _listadoTelefonica;
        public frmTarjetasAgregar()
        {
            InitializeComponent();
        }

        public frmTarjetasAgregar(Denominacion entity)
        {
            InitializeComponent();
            id = entity.DenominacionId;
        }

        private void frmTarjetasAgregar_Load(object sender, EventArgs e)
        {
            UpdateCombo();
        }

        private void UpdateCombo()
        {
            _listadoTelefonica = TelefonicaBL.Instance.SelectAll();
            comboBoxTeefonica.DataSource = _listadoTelefonica;
            comboBoxTeefonica.DisplayMember = "Nombre";
            comboBoxTeefonica.ValueMember = "TelefonicaId";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBoxId.Text == "")
            {
                errorProvider1.SetError(textBoxId, "Campo obligatorio");
                return;
            }

            if (textBoxNombre.Text == "")
            {
                errorProvider1.SetError(textBoxNombre, "Campo obligatorio");
                return;
            }

            if (maskedTextBoxPrecio.Text == "_.__")
            {
                errorProvider1.SetError(maskedTextBoxPrecio, "Campo obligatorio");
                return;
            }


            if (maskedTextBoxCosto.Text == "_.__")
            {
                errorProvider1.SetError(maskedTextBoxCosto, "Campo obligatorio");
                return;
            }


            Denominacion entity = new Denominacion()
            {
                DenominacionId = textBoxId.Text.Trim(),
                Nombre = textBoxNombre.Text.Trim(),
                Precio = decimal.Parse(maskedTextBoxPrecio.Text),
                Costo = decimal.Parse(maskedTextBoxCosto.Text),
                TelefonicaId = (int) comboBoxTeefonica.SelectedValue
            };

            if (id =="")
            {
                entity.DenominacionId = id;
                if (DenominacionBL.Instance.Update(entity))
                {
                    MessageBox.Show("Se Modifico con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                if (DenominacionBL.Instance.Insert(entity))
                {
                    MessageBox.Show("Se agrego con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            this.Close();
        }
    }
}
