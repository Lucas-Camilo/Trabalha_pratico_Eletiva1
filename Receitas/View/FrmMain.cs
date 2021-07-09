using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Receitas.View
{
    public partial class FrmMain : Form
    {
        public FrmMain(int id)
        {
            InitializeComponent();
            ID = id;
        }
        private int ID;
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
    }
}
