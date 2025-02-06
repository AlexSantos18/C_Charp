using System.ComponentModel;
using System.Diagnostics;
using System.Net;

string n;
Console.Write("Digite um nome: ");
n = Console.ReadLine();
n = n.Trim();
n = n.ToUpper();
char ch = 'A';
int freq = 0;
foreach (char c in n)
{
    if (c == ch)
    {
        freq++;
    }
}
Console.WriteLine("A Letra A apareceu {0} vezes.", freq);
Console.WriteLine("A primeira posiçao da letra A foi na posiçao {0}.",n.IndexOf(ch));
Console.WriteLine("A ultima posiçao da letra A foi na posiçao {0}", n.LastIndexOf(ch));

