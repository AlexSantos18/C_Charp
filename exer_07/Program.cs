float n1, n2;
float media;
Console.Write("Digite uma nota: ");
n1 = float.Parse(Console.ReadLine());
Console.Write("Digite outra nota: ");
n2 = float.Parse(Console.ReadLine());
media = (n1 + n2)/2;
Console.WriteLine("Sua primeira nota foi {0}\nSua Segunda foi {1}\nE a media obitida {2:N2}",n1, n2, media);
