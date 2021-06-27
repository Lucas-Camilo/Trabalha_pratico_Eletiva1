using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Receitas.Controlller
{
    class ClsConexao
    {
        public SqlConnection conexao = new SqlConnection();
        public void conectar()
        {
            try
            {
                conexao.ConnectionString = @"Data Source=INOVACAO-PC\INOVACAO;Initial Catalog=SistemaIdeias;Persist Security Info=True;User ID=sa;Password=GkXXuVbw";
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// desconecta do banco
        public void desconectar()
        {
            conexao.Close();
        }
    }
}