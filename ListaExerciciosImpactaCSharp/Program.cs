namespace exercicio5
{
    public class Program
    {
        static void Main(string[] args)
        {
            int resultado;
            Console.WriteLine("Informe um número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            resultado = num - 1;
            Console.WriteLine($"Número digitado é: {num}, seu antecessor é: {resultado}");

            Console.ReadKey();
        }
    }
}