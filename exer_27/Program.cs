using System.Runtime.CompilerServices;

string n;
Console.Write("Digite o se nome completo: ");
n = Console.ReadLine();
n = n.ToUpper();
int cont = 0;
string[] lista = n.Split(' ');
cont = lista.Length - 1;
Console.WriteLine("O primeiro nome é {0}", lista[0]);
Console.WriteLine("O ultimo nome é {0}", lista[cont]);
