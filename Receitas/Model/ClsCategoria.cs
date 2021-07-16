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
    class ClsCategoria
    {
        private int id;
        private string categoria;
        
        public ClsCategoria()
        { }

        public ClsCategoria(int n_id, string n_categoria)
        {
            id = n_id;
            categoria = n_categoria;
        }
        public ClsCategoria(string n_categoria)
        {
            categoria = n_categoria;
        }
        
        public void InserirCategoria()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            MySqlCommand cmd;
            try
            {
                string query = "INSERT INTO categoria(categoria) Values (@CATEGORIA)";
                cmd = new MySqlCommand(query, conexao.conexao);
                cmd.Parameters.AddWithValue("@CATEGORIA", categoria);
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
        public void SelecionarPorId()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            MySqlCommand cmd;
            try
            {
                string query = "Select idcategoria from categoria Where categoria = @CATEGORIA";
                cmd = new MySqlCommand(query, conexao.conexao);
                cmd.Parameters.AddWithValue("@CATEGORIA", categoria);
                MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (dr.Read())
                {
                    id = int.Parse(dr["idcategoria"].ToString());
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
        public void DeletarCategoria()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            MySqlCommand cmd;
            try
            {
                string query = "Delete from categoria WHERE idcategoria = @ID";
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
                conexao.desconectar();
            }
        }
        public void AtalizarCategoria(string n_categoria)
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            MySqlCommand cmd;
            try
            {
                string query = "UPDATE categoria SET categoria = @CATEGORIA WHERE idcategoria = @ID";
                cmd = new MySqlCommand(query, conexao.conexao);
                cmd.Parameters.AddWithValue("@CATEGORIA", n_categoria);
                cmd.Parameters.AddWithValue("@ID", id);
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
        public int getId()
        {
            return id;
        }
    }
}
