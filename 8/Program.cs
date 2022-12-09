/*Escreva um algoritmo para ler o número total de eleitores de um município, o número de votos
brancos, nulos e válidos. Calcular e escrever o percentual que cada um representa em relação ao total
de eleitores.*/

using _8;

namespace exercicio8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Votacao votacao = new Votacao();

            Console.WriteLine("Bem-vindo ao sistema de votação!");
            Console.WriteLine("Por favor informe a quantidade de eleitores que votarão.");
            votacao.Total = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < votacao.Total; i++)
            {
                Console.WriteLine("Digite 1 para Nulo | 2 para Branco | " +
                    "3 para candidato A | 4 para candidato B");
                int voto = Convert.ToInt32(Console.ReadLine());

                switch (voto)
                {
                    case 1:
                        // código 1
                        break;
                    case 2:
                        // código 2
                        break;
                    case 3:
                        // código 1
                        break;
                    case 4:
                        // código 1
                        break;
                    default:
                        break;
                }

            }

            Console.ReadKey();
        }
    }
}