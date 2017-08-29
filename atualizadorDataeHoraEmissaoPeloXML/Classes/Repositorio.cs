using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atualizador.Classes
{
   public class Repositorio<TTipo>
    {
        private List<TTipo> list;

        public Repositorio()
        {
            list = new List<TTipo>();
        }

        public List<TTipo> Get()
        {
            return list;
        }

        public void Insert(TTipo meuObjeto)
        {
            list.Add(meuObjeto);
        }
    }
}
