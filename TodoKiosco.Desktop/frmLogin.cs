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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            Usuario entity =  UsuarioBL.Instance.Login(usuario, password);
            if(entity.Email != null)
            {
                //OK
                frmPrincipal frm = new frmPrincipal(entity);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o password son incorrectos, vuelva a intentar!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
