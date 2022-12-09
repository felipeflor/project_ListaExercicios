using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Votacao
    {
        public int Brancos { get; set; }
        public int Nulos { get; set; }
        public int Validos { get; set; }
        public int Total { get; set; }

        public virtual string Validacao()
        {
            string retorno;
            int validacao = Brancos + Nulos + Validos;
            while(Total >= validacao)
            {
                retorno = ("Não será possível efetuar votação. Excedido limite de eleitores informados!");
                break;
            }
            return retorno = ("Obrigado por votar!");
        }
        /*public virtual string ExibirDados()
        {
            
        }*/
    }
}
