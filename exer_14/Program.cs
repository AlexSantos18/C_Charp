double c, k, f;
Console.Write("Qual a temperatudo para conversão: ");
c = double.Parse(Console.ReadLine());
k = c + 273;
f = (c * 1.8) + 32;
Console.WriteLine("A temperatura {0} conferida em kelvin é {1} e conferida em fahrenheit é {2}", c,k,f);
