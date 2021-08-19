using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace PLATAFORMA_JOGOS
{
    class AcessoBD
    {
        SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-0V23QDG;Initial Catalog=dbJogosInterativos;User ID=sa;Password=1234567");

        public AcessoBD()
        {
        }
        public SqlConnection Entrar()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }
            return conexao;
        }
        public void Sair()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
