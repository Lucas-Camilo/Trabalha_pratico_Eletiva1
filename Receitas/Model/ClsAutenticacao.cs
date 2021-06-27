using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Receitas.Controlller;
using System.Data;
using System.Data.SqlClient;

namespace Receitas.Model
{
    class ClsLogin
    {

        private int mID_Colaborador;

        public int ID_Colaborador
        {
            get { return mID_Colaborador; }
            set { mID_Colaborador = value; }
        }

        private string mDS_Perfil;

        public string DS_Perfil
        {
            get { return mDS_Perfil; }
            set { mDS_Perfil = value; }
        }
        private string mDS_login;

        public string DS_login
        {
            get { return mDS_login; }
            set { mDS_login = value; }
        }
        private string mDs_senha;

        public string Ds_senha
        {
            get { return mDs_senha; }
            set { mDs_senha = value; }
        }

        private string mNM_Colaborador;

        public string NM_Colaborador
        {
            get { return mNM_Colaborador; }
            set { mNM_Colaborador = value; }
        }


        public ClsLogin() { }


        public ClsLogin(string Ds_login, string Ds_senha)
        {

            mDS_login = Ds_login;
            mDs_senha = Ds_senha;

        }

        public void acessaSistema()
        {

            ClsConexao conexao = new ClsConexao();
            conexao.conectar();

            string query = "SELECT * FROM TB_Colaborador WHERE Ds_Login = @Ds_Login AND DS_Senha = @DS_Senha";
            try
            {
                SqlCommand cmd = new SqlCommand(query, conexao.conexao);
                cmd.Parameters.AddWithValue("@Ds_Login", mDS_login);
                cmd.Parameters.AddWithValue("@DS_Senha", mDs_senha);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                ClsAutenticacao.login(dr["Ds_Login"].ToString(), dr["DS_Senha"].ToString(), Convert.ToInt32(dr["ID_Colaborador"].ToString()));
                //lbl.Text = dr["ID_USUARIO"].ToString() + " - " + dr["NM_Usuario"].ToString();
                mID_Colaborador = int.Parse(dr["ID_Colaborador"].ToString());
                mDS_Perfil = dr["DS_Perfil"].ToString();
                mNM_Colaborador = dr["NM_Colaborador"].ToString();
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