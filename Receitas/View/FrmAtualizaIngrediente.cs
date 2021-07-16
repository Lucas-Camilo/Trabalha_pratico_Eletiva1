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
    public partial class FrmAtualizaIngrediente : Form
    {
        public FrmAtualizaIngrediente()
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
                cbxUnidade.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Nenhum ingrediente cadastrado. Por favor cadastre um novo ingrediente !");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ClsIngrediente n_ingrediente = new ClsIngrediente();
            string nome = txtIngrediente.Text;
            string uni = cbxUnidade.Text;
            int quant = 0;
            try
            {
                quant = int.Parse(txtQuant.Text);
            }
            catch
            {
                MessageBox.Show("Por Favor coloque uma quantidade válida");
            }
            string descricao = txtDescricao.Text;
;            if(!nome.Equals("") && !uni.Equals("") && !descricao.Equals("") && !txtQuant.Text.Equals("") && quant > 0)
            {
                n_ingrediente = new ClsIngrediente(cbxIngrediente.Text);
                n_ingrediente.SelecionarIDPorNome();
                n_ingrediente.AtualizarIngrediente(nome, uni, quant, descricao);
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor preencha as informações acima.");
                txtIngrediente.Focus();
            }
        }
    }
}
