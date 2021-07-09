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
        private string Nome;
        private string Senha;
        private string Perfil;
        public ClsUsuario()
        { }

        public ClsUsuario(string nome)
        {
            Nome = nome;
        }

        public ClsUsuario(string nome, string senha)
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
                string query = "INSERT INTO login(login, senha, perfil) Values(@LOGIN, @SENHA, 'Usuario')";
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
            {
                conexao.desconectar();
            }
        }
        public void SelecionarIDPorNome()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            MySqlCommand cmd;
            try
            {
                string query = "Select id from login Where login =@NOME";
                cmd = new MySqlCommand(query, conexao.conexao);
                cmd.Parameters.AddWithValue("@NOME", Nome);
                MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if(dr.Read())
                {
                    ID = int.Parse(dr["id"].ToString());
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Falha na operação: " + ex.Message);
            }
            finally
            {
                conexao.desconectar();
            }
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
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.ExecuteReader(CommandBehavior.SingleRow);
            }
            catch (MySqlException ex)
            {
                throw new Exception("Falha na operação: " + ex.Message);
            }
            finally
            {
                conexao.desconectar();
            }
        }
        public void AtalizarUsuario(string n_nome, string n_senha, string n_perfil)
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            MySqlCommand cmd;
            try
            {
                string query = "UPDATE login SET login= @LOGIN, senha = @SENHA, perfil= @PERFIL WHERE id = @ID";
                cmd = new MySqlCommand(query, conexao.conexao);
                cmd.Parameters.AddWithValue("@LOGIN", n_nome);
                cmd.Parameters.AddWithValue("@SENHA", n_senha);
                cmd.Parameters.AddWithValue("@PERFIL", n_perfil);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.ExecuteReader(CommandBehavior.SingleRow);
            }
            catch (MySqlException ex)
            {
                throw new Exception("Falha na operação: " + ex.Message);
            }
            finally
            {
                conexao.desconectar();
            }
        }
    }
}
