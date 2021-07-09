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
    public partial class FrmDeletarCategoria : Form
    {
        public FrmDeletarCategoria()
        {
            InitializeComponent();
            PreencheCombo();
        }
        public void PreencheCombo()
        {
            ClsCarregamento.carregarComboBox(cbxCategoria, "Select categoria from categoria");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cbxCategoria.Text.Equals(""))
            {
                MessageBox.Show("Por favor selecione uma Categoria");
            }
            else
            {
                ClsCategoria categoria = new ClsCategoria(cbxCategoria.Text);
                categoria.SelecionarPorId();
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir a Categoria?", "Confirmação", buttons);
                if (result == DialogResult.Yes)
                {
                    categoria.DeletarCategoria();
                    this.Close();
                }
            }
        }
    }
}
