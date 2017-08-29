using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace Atualizador.DAO
{
   public class DAOUtils
    {
        private static SqlConnection conexao = new SqlConnection();
        private static string _stringconexao;

        public DAOUtils(string stringconexao)
        {
            _stringconexao = stringconexao;
        }
        public static SqlConnection GetConexao()
        {
            conexao = new SqlConnection(_stringconexao);
            conexao.Open();
            return conexao;
        }
        public static SqlCommand GetComando(SqlConnection conexao)
        {
            SqlCommand comando = conexao.CreateCommand();
            return comando;
        }

   
   
    }
}
