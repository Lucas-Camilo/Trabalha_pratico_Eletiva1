using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Receitas.Controlller;

namespace Receitas.Model
{
    class ClsCarregamento
    {
        public static void CarregaListBox(ListBox ltb, string query)
        {
            ClsConexao conec = new ClsConexao();
            ltb.Items.Clear();

            conec.conectar();

            MySqlCommand cmd = new MySqlCommand(query, conec.conexao);
            MySqlDataReader dr = cmd.ExecuteReader();
            string texto = "";
            while (dr.Read())
            {
                // Regra de Nome para Inserir na ListBox
                texto = dr[0].ToString() + "-" + dr[1].ToString();
                ltb.Items.Add(texto);
            }
            dr.Close();
            conec.desconectar();

        }
    }
}
