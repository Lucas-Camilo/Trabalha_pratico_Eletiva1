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
using Receitas.View;
namespace Receitas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtSenha.MaxLength = 30;
            txtUser.MaxLength = 30;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsLogin login = new ClsLogin();
            string nome = txtUser.Text;
            string senha = txtSenha.Text;
            try
            {
                login = new ClsLogin(nome, senha);
                login.acessaSistema();
                if (login.getID() > 0)
                { 
                    FrmMain main = new FrmMain(login.getID());
                    main.Show();
                    this.Hide();
                   
                }
                else
                {
                    MessageBox.Show("Você ainda não tem acesso ao sistema");
                }
            }
            catch
            {
                txtUser.Text = "";
                txtSenha.Text = "";
                MessageBox.Show("Você ainda não tem acesso ao sistema");
            }
        }
    }
}
