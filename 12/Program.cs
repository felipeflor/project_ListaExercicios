using _12;

namespace exercicio12
{
    public class Program
    {
        static void Main(string[] args)
        {
            Conversor conversor = new Conversor();

            Console.WriteLine("Olá, bem vindo ao conversor de temperatura Fahrenheit Celsius!");
            Console.WriteLine("Digite 1 para converter Fahrenheit para Celsius\n" +
                "Digite 2 para converter Celsius para Fahrenheit");
            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Write("Informe temperatura em graus Fahrenheit: ");
                conversor.Fahrenheit = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Temperatura convertida para {conversor.FpC()}ºC");

            }else if(opcao == 2)
            {
                Console.Write("Informe temperatura em graus Celsius: ");
                conversor.Celsius = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Temperatura convertida para {conversor.CpF()}ºF");

            }

            

            Console.ReadKey();
        }
    }
}