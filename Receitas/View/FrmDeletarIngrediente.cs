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
    public partial class FrmDeletarIngrediente : Form
    {
        public FrmDeletarIngrediente()
        {
            InitializeComponent();
            PreencheCombo();
        }
        public void PreencheCombo()
        {
            ClsCarregamento.carregarComboBox(cbxIngrediente, "Select nome from ingredientes");

            try
            {
                cbxIngrediente.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Nenhum ingrediente cadastrado. Por favor cadastre um novo ingrediente !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o usuário?", "Confirmação", buttons);
            ClsIngrediente ingrediente = new ClsIngrediente();
            if (!cbxIngrediente.Text.Equals(""))
            {
                ingrediente = new ClsIngrediente(cbxIngrediente.Text);
                ingrediente.SelecionarIDPorNome();
                if (result == DialogResult.Yes)
                {
                    ingrediente.DeletarIngrediente();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Por Favor selecione um ingrediente a ser excluido");
            }
        }
    }
}
