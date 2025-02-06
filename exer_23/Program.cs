string n;
int i;
Console.Write("digite um numero entre 0 e 9999: ");
n = Console.ReadLine();
i = int.Parse(n);
Console.WriteLine("Analisando o numero....");
if (i > 999)
{
    Console.WriteLine("Unidade: {0}, Dezena: {1}, Centena: {2}, Milhar: {3}.",n[3],n[2],n[1],n[0]);
}
else if (i >99)
{
    Console.WriteLine("Unidade: {0}, Dezena: {1}, Centena: {2}",n[2],n[1],n[0]);
}
else if (i > 9)
{
    Console.WriteLine("Unidade: {0}, Dezena: {1}",n[1],n[0]);
}
else
{
    Console.WriteLine("Unidade: {0}",n[0]);
}