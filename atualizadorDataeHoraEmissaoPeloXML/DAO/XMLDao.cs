using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atualizador.Classes;

namespace Atualizador.DAO
{
    class XMLDAO
    {


        public DataTable CapturarTabelas()
        {
            SqlConnection conexao = DAOUtils.GetConexao();

            DataTable dtTabelas = conexao.GetSchema("Tables");
            conexao.Close();
            return dtTabelas;
        }

        public DataTable CapturarCampos(string tabela)
        {
            SqlConnection conexao = DAOUtils.GetConexao();
            DataTable dtColuna = conexao.GetSchema("Columns", new[] { "Gestor", null, tabela });
            return dtColuna;
        }

        public static bool Atualizar(string tabela, string campo, string valor, string chave, string data, string hora)
        {
            Utils utils = new Utils();
            SqlConnection conexao = DAOUtils.GetConexao();
            SqlCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            StringBuilder sb = new StringBuilder();
            {
                sb.Append("UPDATE ");
                sb.Append(tabela);
                sb.Append(" SET ");
                sb.Append(campo);
                sb.Append(" = '");
                sb.Append(utils.formataDataEHora(data, hora));
                sb.Append("' WHERE ");
                sb.Append(valor);
                sb.Append(" = '");
                sb.Append(chave);
                sb.Append("'");
            };


            comando.CommandText = sb.ToString();
            comando.ExecuteNonQuery();
            return true;
        }
    }
}
