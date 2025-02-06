float a, b, c;
Console.Write("Primeiro lado: ");
a = float.Parse(Console.ReadLine());
Console.Write("Segundo lado: ");
b = float.Parse(Console.ReadLine());
Console.Write("Terceiro lado: ");
c = float.Parse(Console.ReadLine());

// testando se é um triangulo
if ((a + b < c) | (a + c < b) | (b + c < a))
{
    Console.WriteLine("Nao é um triangulo");
}
else if ((a == b) && (a == c))
{
    Console.WriteLine("Equilatero");
}
else if ((a == b) | (a == c) | (b == c))
{
    Console.WriteLine("Isosceles");
}
else
{
    Console.WriteLine("Escaleno");
}
