namespace exercicio15
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um valor para verificação: ");
            double x = Convert.ToDouble(Console.ReadLine());

            if(x >= 0)
            {
                Console.WriteLine("Número digitado é positivo");
            }
            else
            {
                Console.WriteLine("Número digitado é negativo");
            }

            Console.ReadKey();
        }
    }
}