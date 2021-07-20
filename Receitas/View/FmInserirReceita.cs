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
using System.IO;

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
        private string enderecoDaFoto1;

        public void PreencheCombo()
        {
            ClsCarregamento.carregarComboBox(cbxCategoria, "Select categoria from categoria");
            ClsCarregamento.carregarComboBox(cbxIngrediente, "Select nome from ingredientes");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ingrediente = cbxIngrediente.Text;
            cbxIngrediente.SelectedIndex = -1;
            if(!ingrediente.Equals(""))
            {
                cbxIngredienteReceita.Items.Add(ingrediente);
            }
            
            ingredientes += "\"" + ingrediente + "\", ";
            ingredientes = ingredientes.Remove(ingredientes.Length - 1);
            string tmp = ingredientes.Remove(ingredientes.Length - 1);
            ClsCarregamento.carregarComboBox(cbxIngrediente, "Select nome from ingredientes where nome not in (" + tmp + ")");

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
            if(!txtTitulo.Text.Equals("") && !txtOBS.Text.Equals("") && !txtDicas.Text.Equals("") && !txtModo.Text.Equals("") && !enderecoDaFoto1.Equals("") && !ingredientes.Equals(""))
            {
                ClsReceitas receitas = new ClsReceitas(categoria.getId(), txtTitulo.Text, txtOBS.Text, txtDicas.Text, txtModo.Text);
                receitas.foto1 = ConvertFoto(enderecoDaFoto1);
                receitas.InserirReceita();
                receitas.SelecionarPorId();

                foreach(string ingrediente in cbxIngrediente.Items)
                {
                    ClsIngrediente tmp_Ingre = new ClsIngrediente(ingrediente);
                    tmp_Ingre.SelecionarIDPorNome();
                    receitas.CriaAssosiacao(tmp_Ingre.getID());
                }
                this.Close();

            }
            else
            {
                MessageBox.Show("Favor, preencha os valores acima");
                txtTitulo.Focus();
            }
        }

        private void AbrirFoto1()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|ALLFiles((*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                enderecoDaFoto1 = dialog.FileName.ToString();
                pcbImagem1.ImageLocation = enderecoDaFoto1;
                pcbImagem1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private byte[] ConvertFoto(string foto)
        {
            byte[] imagem_byte = null;
            if (foto == "") 
            {
                return null; 
            }
            FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs); 
            imagem_byte = br.ReadBytes((int)fs.Length); 

            return imagem_byte; //RETORNA UMA IMAGEM CONVERTIDA EM ARRAY DE BYTE
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFoto1();
        }
    }
}
