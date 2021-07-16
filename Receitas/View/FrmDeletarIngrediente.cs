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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsIngrediente ingrediente = new ClsIngrediente();
            if (!cbxIngrediente.Text.Equals(""))
            {
                ingrediente = new ClsIngrediente(cbxIngrediente.Text);
                ingrediente.SelecionarIDPorNome();
                ingrediente.DeletarIngrediente();
            }
            else
            {
            }
        }
    }
}
