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
    public partial class FrmAtualizaUsuario : Form
    {
        public FrmAtualizaUsuario(int id, bool meuUsuario = true)
        {
            InitializeComponent();
            ID = id;
            MeuUsuario = meuUsuario;
            PreencheCombo();
        }
        private int ID;
        private bool MeuUsuario;
        public void PreencheCombo()
        {
            if (!MeuUsuario)
            {
                ClsCarregamento.carregarComboBox(cbxUsuario, "Select login from login Where id <>" + ID.ToString());
            }
            else
            {
                ClsCarregamento.carregarComboBox(cbxUsuario, "Select login from login Where id =" + ID.ToString());
                cbxUsuario.SelectedIndex = 0;
                cbxUsuario.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUser.Text.Equals("") || txtSenha.Text.Equals(""))
            {
                MessageBox.Show("Favor, preencha os campos acima");
                txtUser.Focus();
            }
            else
            {
                ClsUsuario n_user = new ClsUsuario(cbxUsuario.Text);
                n_user.AtalizarUsuario(txtUser.Text, txtSenha.Text, cbx_perfil.Text);
                this.Close();
            }
        }
    }
}
