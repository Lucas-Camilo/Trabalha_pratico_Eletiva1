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
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInserirUsuario nw_user = new FrmInserirUsuario();
            nw_user.ShowDialog();
        }
    }
}
