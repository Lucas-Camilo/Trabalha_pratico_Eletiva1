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
    class ClsReceitas
    {
        public int id;
        public int idCategoria;
        public string titulo;
        public byte[] foto1;
        public byte[] foto2;
        public byte[] foto3;
        public string obs;
        public string dicas;
        public string modo_preparo;

        public ClsReceitas()
        { }

        public ClsReceitas(string n_titulo)
        {
            titulo = n_titulo;
        }

        public ClsReceitas(int n_idCategoria, string n_titulo, string n_obs, string n_dicas, string n_modoPreparo)
        {
            idCategoria = n_idCategoria;
            titulo = n_titulo;
            obs = n_obs;
            dicas = n_dicas;
            modo_preparo = n_modoPreparo;
        }

        public void InserirReceita()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            MySqlCommand cmd;
            try
            {
                //string query = "INSERT INTO receita(id_categoria,titulo,foto1,foto2,foto3,obs,dicas,modo_preparo) Values (@IDCATEGORIA, @TITULO, @FOTO1, @FOTO2, @FOTO3, @OBS, @DICAS, @MODOPREPARO)";
                string query = "INSERT INTO receita(id_categoria,titulo,foto1,obs,dicas,modo_preparo) Values (@IDCATEGORIA, @TITULO, @FOTO1, @OBS, @DICAS, @MODOPREPARO)";
                cmd = new MySqlCommand(query, conexao.conexao);
                cmd.Parameters.AddWithValue("@IDCATEGORIA", idCategoria);
                cmd.Parameters.AddWithValue("@TITULO", titulo);
                cmd.Parameters.AddWithValue("@FOTO1", foto1);
               // cmd.Parameters.AddWithValue("@FOTO2", foto2);
                //cmd.Parameters.AddWithValue("@FOTO3", foto3);
                cmd.Parameters.AddWithValue("@OBS", obs);
                cmd.Parameters.AddWithValue("@DICAS", dicas);
                cmd.Parameters.AddWithValue("@MODOPREPARO", modo_preparo);
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
                string query = "Select idreceita from receita Where titulo = @TITULO";
                cmd = new MySqlCommand(query, conexao.conexao);
                cmd.Parameters.AddWithValue("@TITULO", titulo);
                MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (dr.Read())
                {
                    id = int.Parse(dr["idreceita"].ToString());
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
        public void DeletarReceita()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            MySqlCommand cmd;
            try
            {
                string query = "Delete from receita WHERE idreceita = @ID";
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
        public void AtalizarReceita(int n_idCategoria, string n_titulo, string n_foto1, string n_foto2, string n_foto3, string n_obs, string n_dicas, string n_modo_preparo)
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            MySqlCommand cmd;
            try
            {
                string query = "UPDATE receita SET id_categoria = @IDCATEGORIA titulo = @TITULO, foto1 = @FOTO1, foto2 = @FOTO2, foto3 = @FOTO3, obs = @OBS, dicas = @DICAS, modo_preparo = @MODOPREPARO WHERE idreceita = @ID";
                cmd = new MySqlCommand(query, conexao.conexao);
                cmd.Parameters.AddWithValue("@IDCATEGORIA", idCategoria);
                cmd.Parameters.AddWithValue("@TITULO", titulo);
                cmd.Parameters.AddWithValue("@FOTO1", foto1);
                cmd.Parameters.AddWithValue("@FOTO2", foto2);
                cmd.Parameters.AddWithValue("@FOTO3", foto3);
                cmd.Parameters.AddWithValue("@OBS", obs);
                cmd.Parameters.AddWithValue("@DICAS", dicas);
                cmd.Parameters.AddWithValue("@MODOPREPARO", modo_preparo);
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

        public void PreencharReceita()
        {
            string query = "SELECT id_categoria, foto1, foto2, foto3, obs, dicas, modo_preparo FROM receita WHERE idreceita = @ID";
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            MySqlCommand cmd;
            try
            {
                cmd = new MySqlCommand(query, conexao.conexao);
                cmd.Parameters.AddWithValue("@ID", id);
                MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if(dr.Read())
                {
                    //id = int.Parse(dr["idreceita"].ToString());
                    idCategoria = int.Parse(dr["id_categoria"].ToString());
                    foto1 = (byte[]) dr["foto1"];
                    obs = dr["obs"].ToString();
                    dicas = dr["dicas"].ToString();
                    modo_preparo = dr["modo_preparo"].ToString();
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
        public void CriaAssosiacao(int idIngrediente)
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            MySqlCommand cmd;
            try
            {
                string query = "INSERT INTO ingredientes_da_receita(id_ingredientes, id_receita) VALUES(@IDRECEITA, @IDINGREDIENTE)";
                cmd = new MySqlCommand(query, conexao.conexao);
                cmd.Parameters.AddWithValue("@IDRECEITA", id);
                cmd.Parameters.AddWithValue("@IDINGREDIENTE", idIngrediente);
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