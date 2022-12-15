namespace exercicio14
{
    public class Program
    {
        static void Main(string[] args)
        {
            double num, dez;

            Console.WriteLine("Informe um número para comparação: ");
            num = Convert.ToDouble(Console.ReadLine());
            dez = 10;

            if(num < dez)
            {
                Console.WriteLine("Valor informado é menor que 10!");
            }
            else if(num == dez)
            {
                Console.WriteLine("Valor informado é igual a 10!");
            }
            else
            {
                Console.WriteLine("Valor informado é maior que 10!");
            }

            Console.ReadKey();

        }
    }
}