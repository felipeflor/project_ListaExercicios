using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Calculo
    {
        public double CustoFabrica { get; set; }
        public double Imposto { get; set; }
        public double Distribuidor { get; set; }
        public virtual string ExibirDados()
        {
            Imposto = (CustoFabrica * 1.45) - CustoFabrica;
            Distribuidor = (CustoFabrica * 1.28) - CustoFabrica;
            double custoFinal = CustoFabrica + Imposto + Distribuidor;
            return ($"-------------------------\n" +
                $"Custo de fábrica: R${CustoFabrica}\nImposto: R${Imposto}\n" +
                $"Distribuidor: R${Distribuidor}\nCusto final: R${custoFinal}\n" +
                $"-------------------------");
            
        }
    }
}
