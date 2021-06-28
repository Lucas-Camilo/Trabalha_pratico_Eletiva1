using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Receitas.Controlller;
using System.Data;
using MySql.Data.MySqlClient;
namespace Receitas.Model
{
    class ClsLogin
    {
        private int id;
        private string login;
        private string senha;

        public ClsLogin() { }

        public ClsLogin(string Ds_login, string Ds_senha)
        {
            login = Ds_login;
            senha = Ds_senha;
        }
        public int getID()
        {
            return id;
        }
        public void acessaSistema()
        {

            ClsConexao conexao = new ClsConexao();
            conexao.conectar();

            string query = "SELECT * From login WHERE login = @login AND senha = @senha";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conexao.conexao);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@senha", senha);
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                ClsAutenticacao.login(dr["login"].ToString(), dr["senha"].ToString(), Convert.ToInt32(dr["id"].ToString()));
                id = int.Parse(dr["id"].ToString());
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexao.desconectar();
            }
        }
    }
}