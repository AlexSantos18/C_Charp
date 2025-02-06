while (true)
{
    Console.Clear();
    int n, resp;
    Console.Write("Digite um valor inteiro: ");
    n = int.Parse(Console.ReadLine());
    Console.WriteLine("Escolha uma opçao para conversao");
    Console.WriteLine("[ 1 ] para BINARIO");
    Console.WriteLine("[ 2 ] para OCTAL");
    Console.WriteLine("[ 3 ] para HEXADECIMAL");
    Console.WriteLine("[ 0 ] para Sair");
    resp = int.Parse(Console.ReadLine());
    int resultado;
    if (resp == 0)
        break;
    if (resp == 1)
    {
        String binario = "";
        if (n != 0)
            while (n > 0)
            {
                resultado = (n % 2);
                binario = resultado.ToString() + binario;
                n /= 2;
            }
        Console.WriteLine("{0} convertido para BINARIO.", binario);
        Console.ReadLine();
    }
    if (resp == 2)
    {
        String octal = "";
        if (n != 0)
            while (n > 0)
            {
                resultado = (n % 8);
                octal = resultado.ToString() + octal;
                n /= 8;
            }
        Console.WriteLine("{0} convertido para OCTAL.", octal);
        Console.ReadLine();
    }
    if (resp == 3)
    {
        String hexa = "";
        if (n != 0)
        {
            hexa = n.ToString("x");
        }
        Console.WriteLine("{0} convertido para HEXADECIMAL.", hexa);
        Console.ReadLine();
    }
}
