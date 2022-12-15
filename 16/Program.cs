decimal preco, total;
int x;

Console.Write("Informe a quantidade de maças a serem compradas: ");
x = Convert.ToInt32(Console.ReadLine());

if (x < 12)
{
    preco = 1.30m;
    total = preco * x;
    Console.WriteLine($"Valor total: R${total}");
}
else
{
    preco = 1.00m;
    total = preco * x;
    Console.WriteLine($"Valor total: R${total}");
}

Console.ReadKey();