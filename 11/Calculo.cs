using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Calculo
    {
        public double Salario { get; set; }
        public double ComissaoFixa { get; set; }
        public double ComissaoVariavel { get; set; }
        public int QdtVendas { get; set; }
        public double Vendas { get; set; }
        public virtual string CalculoSalario()
        {
            ComissaoFixa = ((Salario * 1.05) - Salario) * QdtVendas;
            ComissaoVariavel = (Vendas * 1.05) - Salario;
            double salarioFinal = Salario + ComissaoFixa + ComissaoVariavel;

            return ($"-------------------------\n" +
                $"Salário base: R${Salario}\nComissão fixa: R${ComissaoFixa}\n" +
                $"Comissão variavel: R${ComissaoVariavel}\nSalario final: R${salarioFinal}\n" +
                $"-------------------------"); ;
        }

    }
}
