var random = new Random();
var lista = new List<string> {};
string n1,n2,n3,n4;
Console.Write("Digite o primeiro nome: ");
lista.Add(Console.ReadLine()); // existe a opçao de ser feito direto sem uma variavel 
//n1 = Console.ReadLine();
Console.Write("Digite o segundo nome: ");
n2 = Console.ReadLine();
Console.Write("Digite o terceiro nome: ");
n3 = Console.ReadLine();
Console.Write("Digite o quarto nome: ");
n4 = Console.ReadLine();
//lista.Add(n1);
lista.Add(n2);
lista.Add(n3);
lista.Add(n4);
Console.WriteLine("O nome escolhido da lista foi {0}",lista[random.Next(lista.Count)]);