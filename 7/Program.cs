using _7;

namespace exercicio7{
    public class Program
    {
        static void Main(string[] args)
        {
            CalcDias calcDias = new CalcDias();

            Console.Write("Informe sua idade: ");
            calcDias.Anos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe os meses completos: ");
            calcDias.Meses = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe dos dias: ");
            calcDias.Dias = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(calcDias.ExibirDados());            

            Console.ReadKey();
        }
    }
}