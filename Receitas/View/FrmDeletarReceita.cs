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
    public partial class FrmDeletarReceita : Form
    {
        public FrmDeletarReceita()
        {
            InitializeComponent();
            PreencheCombo();
        }
        public void PreencheCombo()
        {
            ClsCarregamento.carregarComboBox(cbxReceitas, "Select titulo from receita");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!cbxReceitas.Text.Equals(""))
            {
                ClsReceitas receita = new ClsReceitas(cbxReceitas.Text);
                receita.SelecionarPorId();
                receita.DeletarReceita();
                this.Close();
            }
            else
            {
                MessageBox.Show("Favor, Preencha as informações acima.");
            }
        }
    }
}
