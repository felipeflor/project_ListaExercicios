namespace exercicio13
{
    public class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, mediaFinal;

            Console.Write("Informe nota 1: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe nota 2: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe nota 3: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            mediaFinal = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10;
            Console.WriteLine($"Média do aluno: {mediaFinal}");

            Console.ReadKey();
        }
    }
}