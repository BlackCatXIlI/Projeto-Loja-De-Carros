using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sistema_projetoLojaCarros
{
    internal class Conexao
    {
       
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=LOJA1; user=root;pwd=Mingal26.");

            public static string msg;

            public MySqlConnection ConectarBD()
            {
                try
                {
                    con.Open();
                }
                catch (Exception erro)
                {
                    msg = "Ocorreu um erro ao se conectar" + erro.Message;
                }
                return con;
            }

            public MySqlConnection DesConectarBD()
            {

                try
                {
                    con.Close();
                }

                catch (Exception erro)
                {
                    msg = "Ocorreu um erro ao se conectar" + erro.Message;
                }
                return con;
            }
        
    }
}
