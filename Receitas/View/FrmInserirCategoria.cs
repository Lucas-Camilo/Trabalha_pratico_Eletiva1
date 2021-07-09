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
    public partial class FrmInserirCategoria : Form
    {
        public FrmInserirCategoria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsCategoria Categoria = new ClsCategoria();

            string nome = txtCategoria.Text;
            if (!nome.Equals(""))
            {
                Categoria = new ClsCategoria(nome);
                Categoria.InserirCategoria();
                this.Close();
            }
            else
            {
                MessageBox.Show("Favor, preencha o campo acima");
                txtCategoria.Focus();
            }
        }
    }
}
