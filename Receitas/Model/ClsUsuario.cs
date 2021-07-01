using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Receitas.Controlller;

namespace Receitas.Model
{
    class ClsUsuario
    {
        private int ID;
        private String Nome;
        private String Senha;

        public ClsUsuario()
        { }

        public ClsUsuario(String nome, String senha)
        {
            Nome = nome;
            Senha = senha;
        }

        public void InserirUsuario()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            MySqlCommand cmd;
            try
            {
                string query = "INSERT INTO login(login, senha) Values(@LOGIN, @SENHA)";
                cmd = new MySqlCommand(query, conexao.conexao);
                cmd.Parameters.AddWithValue("@LOGIN", Nome);
                cmd.Parameters.AddWithValue("@SENHA", Senha);
                cmd.ExecuteReader(CommandBehavior.SingleRow);
            }
            catch(MySqlException ex)
            {
                throw new Exception("Falha na operação: " + ex.Message);
            }
            finally
            { }
        }
        public void DeletarUsuario()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            MySqlCommand cmd;
            try
            {
                string query = "Delete from login WHERE id = @ID";
                cmd = new MySqlCommand(query, conexao.conexao);
                cmd.Parameters.AddWithValue("@ID", Nome);
                cmd.ExecuteReader(CommandBehavior.SingleRow);
            }
            catch (MySqlException ex)
            {
                throw new Exception("Falha na operação: " + ex.Message);
            }
        }
    }
}
