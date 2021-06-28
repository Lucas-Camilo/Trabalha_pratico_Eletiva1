using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receitas.Model
{
    class ClsAutenticacao
    {
        private static string usuario;
        private static string senha;
        private static int id;

        public static void login(string DS_login, string DS_senha, int ID_Colaborador)
        {
            usuario = DS_login;
            senha = DS_senha;
            id = ID_Colaborador;
        }

        public static void logout()
        {
            usuario = null;
            senha = null;

        }
        public static String getUsuario()
        {
            return id.ToString() + usuario;
        }


        public static string mNM_Usuario { get; set; }

        public static string mDS_Senha { get; set; }
    }
}
