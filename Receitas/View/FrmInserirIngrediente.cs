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
    public partial class FrmInserirIngrediente : Form
    {
        public FrmInserirIngrediente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string quant = txtQuant.Text;
            string unidade = cbxUnidade.Text;
            string descricao = txtDescricao.Text;

            ClsIngrediente ingrediente = new ClsIngrediente();
            if(nome.Equals("") || quant.Equals("") || unidade.Equals("") || descricao.Equals(""))
            {
                MessageBox.Show("Por favor preencha as informações acima");
            }
            else
            {
                int number1 = 0;
                bool canConvert = int.TryParse(quant, out number1);
                if (canConvert == true)
                {
                    ingrediente = new ClsIngrediente(nome, unidade, int.Parse(quant), descricao);
                    ingrediente.SelecionarIDPorNome();
                    ingrediente.InserirIngrediante();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor digite um numero");
                    txtQuant.Focus();
                }
            }
        }
    }

}
