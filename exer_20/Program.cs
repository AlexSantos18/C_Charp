var random = new Random();
var lista = new List<string> {};
Console.Write("Digite o primeiro nome: ");
lista.Add(Console.ReadLine()); // existe a opçao de ser feito direto sem uma variavel 
Console.Write("Digite o segundo nome: ");
lista.Add(Console.ReadLine());
Console.Write("Digite o terceiro nome: ");
lista.Add(Console.ReadLine());
Console.Write("Digite o quarto nome: ");
lista.Add(Console.ReadLine());
var deck = lista.OrderBy(item => random.Next());

foreach ( var valor in deck)
    Console.WriteLine(valor);