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
    public partial class FrmDeletarUser : Form
    {
        public FrmDeletarUser(int id)
        {
            InitializeComponent();
            ID_Atual = id;
            CarregaListBox();
        }
        private int ID_Atual;
        public void CarregaListBox()
        {
            ClsCarregamento.carregarComboBox(cbxUsuarios, "Select login from login Where id <>"+ID_Atual.ToString());

            try
            {
                cbxUsuarios.SelectedIndex = 0;
            }

            catch
            {
                MessageBox.Show("Nenhum usuario cadastrado. Por favor cadastre um novo usuario !");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o usuário?", "Confirmação", buttons);
            if (!cbxUsuarios.Text.Equals(""))
            {
                ClsUsuario user = new ClsUsuario(cbxUsuarios.Text);
                user.SelecionarIDPorNome();
                if (result == DialogResult.Yes)
                {
                    user.DeletarUsuario();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Favor selecione um usuario para excluir");
            }
        }
    }
}
