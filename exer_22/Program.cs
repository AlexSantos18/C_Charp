string n;
int i;
Console.Write("Digite o seu nome completo: ");
n = Console.ReadLine();
Console.WriteLine("Analisando o seu nome ....");
Console.WriteLine("Seu nome em maiusculo : {0}",n.ToUpper());
Console.WriteLine("Seu nome em minusculo : {0}",n.ToLower());
Console.WriteLine("Seu nome ao todo tem {0} letras.",n.Length);
i = n.IndexOf(" ");
n = n.Substring(0,i);
Console.WriteLine("Seu primeiro nome é {0}.",n);



