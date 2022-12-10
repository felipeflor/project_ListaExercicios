namespace exercicio9
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o salário do funcionário: ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("informe percentual de reajuste: ");
            double porcentReajuste = double.Parse(Console.ReadLine());

            double reajuste = (salario * porcentReajuste) / 100;
            double novoSalario = salario + reajuste;
            Console.WriteLine($"Nono salário após reajuste: R${novoSalario}");

            Console.ReadKey();
        }
    }
}