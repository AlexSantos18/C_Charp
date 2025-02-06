int n = 0;
Console.Write("Digite um numero inteiro: ");
n = int.Parse(Console.ReadLine());
Console.WriteLine($"Analizando o numero digitado {n} seu antessesor foi {--n} e o seu possesor foi {(++n)+1}");
