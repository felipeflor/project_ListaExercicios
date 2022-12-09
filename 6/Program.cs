using _6;

//Escreva um algoritmo para ler as dimensões de um retângulo (base e altura), calcular e escrever a área do retângulo.

namespace exercicio6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo(); 
            
            Console.Write("Informe a base do retângulo: ");
            retangulo.Base = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a altura do retângulo: ");
            retangulo.Altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(retangulo.ExibirDados());

            Console.ReadKey();
        }
    }
}