using _10;

namespace exercicio10 { 
    public class Program
    {
        static void Main(string[] args)
        {
            Calculo calculo = new Calculo();

            Console.Write("Digite custo de fábrica do carro: ");
            calculo.CustoFabrica = Convert.ToDouble(Console.ReadLine());

            Console.Write(calculo.ExibirDados());

            Console.ReadKey();
        }    }

}