int r1, r2, r3;
Console.Write("Digite um comprimento: ");
r1 = int.Parse(Console.ReadLine());
Console.Write("Digite um comprimento: ");
r2 = int.Parse(Console.ReadLine());
Console.Write("Digite um comprimento: ");
r3 = int.Parse(Console.ReadLine());
Console.WriteLine("Calculando ...");
Thread.Sleep(1000);
if (r1 < r2 + r3 && r2<r1 +r3 && r3<r1 + r2)
{
   Console.WriteLine("Voce formou um triangulo");
}
else
{
    Console.WriteLine("Voce nao formou um triangulo");
}



