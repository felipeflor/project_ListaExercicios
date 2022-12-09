using _7;

/*Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade
dessa pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias.*/

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