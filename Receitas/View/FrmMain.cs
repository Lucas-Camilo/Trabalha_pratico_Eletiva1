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
    public partial class FrmMain : Form
    {
        public FrmMain(int id)
        {
            InitializeComponent();
            ID = id;
            preencheListBox();
        }
        private int ID;

        public void preencheListBox()
        {
            ClsCarregamento.CarregaListBox(lsbReceitas, "Select titulo from receita");
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInserirUsuario nw_user = new FrmInserirUsuario();
            nw_user.ShowDialog();
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeletarUser Del_User = new FrmDeletarUser(ID);
            Del_User.ShowDialog();
        }

        private void atualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAtualizaUsuario Upd_User = new FrmAtualizaUsuario(ID);
            Upd_User.ShowDialog();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAtualizaUsuario Upd_User = new FrmAtualizaUsuario(ID, false);
            Upd_User.ShowDialog();
        }

        private void inserirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmInserirCategoria Ins_Categoria = new FrmInserirCategoria();
            Ins_Categoria.ShowDialog();
        }

        private void atualizarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmAtualizaCategoria Upd_Categoria = new FrmAtualizaCategoria();
            Upd_Categoria.ShowDialog();
        }

        private void removerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDeletarCategoria Del_Categoria = new FrmDeletarCategoria();
            Del_Categoria.ShowDialog();
        }

        private void inserirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmInserirIngrediente Ins_Ingrediente = new FrmInserirIngrediente();
            Ins_Ingrediente.ShowDialog();
        }

        private void atualizarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmAtualizaIngrediente Up_Ingrediente = new FrmAtualizaIngrediente();
            Up_Ingrediente.ShowDialog();
        }

        private void removerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmDeletarIngrediente Up_Ingrediente = new FrmDeletarIngrediente();
            Up_Ingrediente.ShowDialog();
        }

        private void inserirToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FmInserirReceita n_Receita = new FmInserirReceita();
            n_Receita.ShowDialog();
        }

        private void removerToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmDeletarReceita n_receita = new FrmDeletarReceita();
            n_receita.ShowDialog();
        }

        private void Pesquisar(object sender, EventArgs e)
        {
            if(!txtPesquisar.Text.Equals(""))
            {
                ClsCarregamento.CarregaListBox(lsbReceitas, "Select titulo from receita Where titulo LIKE '%"+txtPesquisar.Text+"%'");
            }
            else
            {
                ClsCarregamento.CarregaListBox(lsbReceitas, "Select titulo from receita");
            }
        }
    }
}
