using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Retangulo
    {
        public double Altura { get; set; }
        public double Base { get; set; }

        public virtual string ExibirDados()
        {
            double Area = Base * Altura;
            return ($"Altura informada: {Altura}\nBase informada: {Base}\nÁrea do retângulo: {Area}");
        }
    }
}
