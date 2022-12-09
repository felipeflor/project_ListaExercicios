using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class CalcDias
    {
        public int Dias { get; set; }
        public int Meses { get; set; }
        public int Anos { get; set; }

        public virtual string ExibirDados()
        {
            int resultado = (Anos * 365) + (Meses * 30) + Dias;
            return ($"Sua idade total em dias é: {resultado}");
        }
    }
}
