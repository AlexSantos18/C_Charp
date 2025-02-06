
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    private static void Main(string[] args)
    {
        bool Type(double n3) => throw new NotImplementedException();

        double n1, n2, n3;
        n3 = 0;
        Console.Write("Digite um numero: ");
        n1 = double.Parse(Console.ReadLine());
        Console.Write("Digite outro numero: ");
        n2 = double.Parse(Console.ReadLine());
        n3 = n1 + n2;
        Console.WriteLine($"A soma de {n1} e {n2} é {n3}");
        Console.WriteLine((n3));
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}