double real, dolar;
Console.Write("Quantos Reais você tem na carteira R$: ");
real = double.Parse(Console.ReadLine());
dolar = real * 3.27;
Console.WriteLine("Que legal com {0} Reais você pode comprar {1:N2} Dolares.",real,dolar);


