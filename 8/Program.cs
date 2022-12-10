/*Escreva um algoritmo para ler o número total de eleitores de um município, o número de votos
brancos, nulos e válidos. Calcular e escrever o percentual que cada um representa em relação ao total
de eleitores.*/

namespace exercicio8
{
    public class Program
    {
        static void Main(string[] args)
        {
            int nulo = 0, branco = 0, valido = 0;

            Console.WriteLine("Bem-vindo ao sistema de votação!");
            Console.WriteLine("Por favor informe a quantidade de eleitores que votarão.");
            int total = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("Digite 1 para Nulo | 2 para Branco | " +
                    "3 para candidato A | 4 para candidato B");
                int voto = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Você escolheu a opção: {voto}");

                if(voto == 1)
                {
                    nulo = nulo + 1;
                }else if(voto == 2)
                {
                    branco++;
                }else if(voto == 3)
                {
                    valido++;
                }else if(voto == 4)
                {
                    valido++;
                }

            }

            double porcentNulo, porcentBranco, porcentValido;
            porcentNulo = (total * nulo) / 100;
            porcentBranco = (total * branco) / 100;
            porcentValido = (total * valido) / 100;

            Console.Write($"Porcetagem de votos nulos: {porcentNulo}%\n" +
                $"Porcetagem de votos brancos: {porcentBranco}%\n" +
                $"Porcentagem de votos válidos: {porcentValido}%");

            Console.ReadKey();
        }
    }
}