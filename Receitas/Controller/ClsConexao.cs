using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Receitas.Controlller
{
    class ClsConexao
    {
        public MySqlConnection conexao = new MySqlConnection();
        public void conectar()
        {
            try
            {
                conexao.ConnectionString = "user id=root;persistsecurityinfo=True;server=localhost;database=receitas_vovo";
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