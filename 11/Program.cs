using _11;

namespace exercicio11
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculo calculo = new Calculo();

            Console.Write("Informe salário fixo dos vendedores: ");
            calculo.Salario = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a quantidade de unidades vendidas: ");
            calculo.QdtVendas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe valor em reais vendidos: ");
            calculo.Vendas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(calculo.CalculoSalario());

            Console.ReadKey();

        }
    }
}