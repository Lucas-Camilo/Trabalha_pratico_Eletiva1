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
    class ClsIngrediente
    {
        private int id;
        private string nome;
        private string unidade;
        private int quantidade;
        private string descricao;

        public ClsIngrediente()
        { }

        public ClsIngrediente(string n_nome, string n_unidade, int n_quant, string n_descricao)
        {
            nome = n_nome;
            unidade = n_unidade;
            quantidade = n_quant;
            descricao = n_descricao;
        }

        public ClsIngrediente(string n_nome)
        {
            nome = n_nome;
        }

        public void InserirIngrediante()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            MySqlCommand cmd;
            try
            {
                string query = "INSERT INTO ingredientes(nome, unidade, quantidade, descricao) Values(@NOME, @UNIDADE, @QUANTIDADE, @DESCRICAO)";
                cmd = new MySqlCommand(query, conexao.conexao);
                cmd.Parameters.AddWithValue("@NOME", nome);
                cmd.Parameters.AddWithValue("@UNIDADE", unidade);
                cmd.Parameters.AddWithValue("@QUANTIDADE", quantidade);
                cmd.Parameters.AddWithValue("@DESCRICAO", descricao);
                cmd.ExecuteReader(CommandBehavior.SingleRow);
            }
            catch (MySqlException ex)
            {
                throw new Exception("Falha na operação: " + ex.Message);
            }
            finally
            {
                // conexao.Close()
            }
        }
        public void SelecionarIDPorNome()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            MySqlCommand cmd;
            try
            {
                string query = "Select idingredientes from ingredientes Where nome =@NOME";
                cmd = new MySqlCommand(query, conexao.conexao);
                cmd.Parameters.AddWithValue("@NOME", nome);
                MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (dr.Read())
                {
                    id = int.Parse(dr["idingredientes"].ToString());
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
        public void DeletarIngrediente()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            MySqlCommand cmd;
            try
            {
                string query = "Delete from ingrediente WHERE idingredientes = @ID";
                cmd = new MySqlCommand(query, conexao.conexao);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteReader(CommandBehavior.SingleRow);
            }
            catch (MySqlException ex)
            {
                throw new Exception("Falha na operação: " + ex.Message);
            }
            finally
            {
                // conexao.Close()
            }
        }
        public void AtualizarIngrediente(string n_nome, string n_unidade, int n_quant, string n_descricao)
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            MySqlCommand cmd;
            try
            {
                string query = "UPDATE ingrediente SET nome = @NOME, unidade  = @UNIDADE, quantidade  = @QUANTIDADE, descricao  = @DESCRICAO WHERE id = @ID";
                cmd = new MySqlCommand(query, conexao.conexao);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@NOME", n_nome);
                cmd.Parameters.AddWithValue("@UNIDADE", n_unidade);
                cmd.Parameters.AddWithValue("@QUANTIDADE", n_quant);
                cmd.Parameters.AddWithValue("@DESCRICAO", n_descricao);
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
        public int getID()
        {
            return id;
        }
    }
}