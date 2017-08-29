using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atualizador.Classes
{
   public class Utils
    {
        public string MontarQueryDeExemplo(string tabela, string campochavedeacesso = null, string campodataehora = null)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE ");
            sb.Append(tabela);

            if(campodataehora != null)
            {
                sb.Append(" SET ");
                sb.Append(campodataehora);
                sb.Append("=");
                sb.Append("{dataehora}");
            }

            if(campochavedeacesso != null)
            {
                sb.Append(" WHERE (");
                sb.Append(campochavedeacesso);
                sb.Append(" = {chavedeacesso})");
            }
                      
            return sb.ToString();
        }

        public string formataDataEHora(string data, string hora)
        {
            DateTime dataFormatada;
            try
            {
                dataFormatada = Convert.ToDateTime(data + " " + hora + ".000");
            }
            catch (Exception)
            {

                 dataFormatada = Convert.ToDateTime(data + " " + hora.Remove(8, 6) + ".000");
            }
           
            return dataFormatada.ToString("yyyy-dd-MM HH:mm:ss.fff");
        }
    }
}
