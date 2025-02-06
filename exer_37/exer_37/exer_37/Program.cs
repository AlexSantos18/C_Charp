int n, resp;
Console.Write("Digite um valor inteiro: ");
n = int.Parse(Console.ReadLine());
Console.WriteLine("Escolha uma opçao para conversao");
Console.WriteLine("[ 1 ] para BINARIO");
Console.WriteLine("[ 2 ] para OCTAL");
Console.WriteLine("[ 3 ] para HEXADECIMAL");
resp = int.Parse(Console.ReadLine());
if (resp == 1)
{
    string binario = string.Empty;
    binario = Convert.ToString(n, 2);
    Console.WriteLine("{0} convertido para BINARIO.", binario);
    Console.ReadLine();
}
if (resp == 2)
{
    string octal = string.Empty;
    octal = Convert.ToString(n, 8);
    Console.WriteLine("{0} convertido para OCTAL.", octal);
    Console.ReadLine();
}
if (resp == 3)
{
    string  hexa = string.Empty;
    hexa = n.ToString("x");
    Console.WriteLine("{0} conertido em HEXADECIMAL.", hexa);
    Console.ReadLine();
}