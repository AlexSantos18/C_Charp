double cp, ca;
Console.Write("Digite o cateto oposto: ");
cp = double.Parse(Console.ReadLine());
Console.Write("Digite o cateto adjacente: ");
ca = double.Parse(Console.ReadLine());
Console.WriteLine("A hipotenusa vai medir {0:N2}.",double.Hypot(cp,ca));
Console.Read();