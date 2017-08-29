using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Atualizador.BarraDeProgresso.Classe
{
    public class Extensao
    {
        public double ParaNumero(string valor)
        {
            return double.Parse(valor.Remove('.').Replace(",", "."));
        }
    }
}
