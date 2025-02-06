int d, k;
double vr;
Console.Write("Qual a quantidade de dias: ");
d = int.Parse(Console.ReadLine());
Console.Write("Qual a quantidade de km rodados: ");
k = int.Parse(Console.ReadLine());
vr = (d * 60.00) + (k * 0.15);
Console.WriteLine("O valor a pagar pelo aluguel é {0:N2}",vr);
