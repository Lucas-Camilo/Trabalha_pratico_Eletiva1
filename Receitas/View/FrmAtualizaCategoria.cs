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
    public partial class FrmAtualizaCategoria : Form
    {
        public FrmAtualizaCategoria()
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
            ClsCategoria categoria = new ClsCategoria();
            if (!cbxCategoria.Text.Equals("") || txtCategoria.Text.Equals(""))
            {
                categoria = new ClsCategoria(cbxCategoria.Text);
                categoria.SelecionarPorId();
                categoria.AtalizarCategoria(txtCategoria.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor preencha as informações acima.");
                txtCategoria.Focus();
            }
        }
    }
}
