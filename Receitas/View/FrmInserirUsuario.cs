using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Receitas.Model;

namespace Receitas.View
{
    public partial class FrmInserirUsuario : Form
    {
        public FrmInserirUsuario()
        {
            InitializeComponent();
            txtUser.MaxLength = 30;
            txtSenha.MaxLength = 30;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string senha = txtSenha.Text;

            if(user.Equals("") || senha.Equals("") )
            {
                MessageBox.Show("Favor, preencha os campos acima");
                txtUser.Focus();
            }
            else
            {
                ClsUsuario n_U = new ClsUsuario(user, senha);
                n_U.InserirUsuario();
                this.Close();
            }
        }

        private void FrmInserirUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
