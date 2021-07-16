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
    public partial class FmInserirReceita : Form
    {
        public FmInserirReceita()
        {
            InitializeComponent();
            PreencheCombo();
            ingredientes = "";
        }
        private string ingredientes;
        public void PreencheCombo()
        {
            ClsCarregamento.carregarComboBox(cbxCategoria, "Select categoria from categoria");
            ClsCarregamento.carregarComboBox(cbxIngrediente, "Select nome from ingredientes");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            byte[] imagem = null;
            string ingrediente = cbxIngrediente.Text;
            cbxIngrediente.SelectedIndex = -1;
            if(!ingrediente.Equals(""))
            {
                cbxIngredienteReceita.Items.Add(ingrediente);
            }
            
            ingredientes += "\"" + ingrediente + "\", ";
            ingredientes = ingredientes.Remove(ingredientes.Length - 1);
            string tmp = ingredientes.Remove(ingredientes.Length - 1);
            while (cbxIngrediente.Items.Count > 0)
            {
                cbxIngrediente.Items.RemoveAt(0);
            }
            ClsCarregamento.carregarComboBox(cbxCategoria, "Select nome from ingredientes where nome not in (" + tmp + ")");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsCategoria categoria = new ClsCategoria(cbxCategoria.Text);
            categoria.SelecionarPorId();
            List<int> ids = new List<int>();
            foreach (var itens in cbxIngredienteReceita.Items)
            {
                ClsIngrediente n_ing = new ClsIngrediente(itens.ToString());
                n_ing.SelecionarIDPorNome();
                ids.Add(n_ing.getID());
            }
            if(!txtTitulo.Text.Equals("") || !txtOBS.Text.Equals("") || !txtDicas.Text.Equals("") || !txtModo.Text.Equals(""))
            {
                ClsReceitas receitas = new ClsReceitas(categoria.getId(), txtTitulo.Text, txtOBS.Text, txtDicas.Text, txtModo.Text);

            }
            else
            {
                MessageBox.Show("Favor, preencha os valores acima");
                txtTitulo.Focus();
            }
            

        }
    }
}
