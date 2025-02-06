double n1, n2, media;
Console.Write("Digite a primeira nota: ");
n1 = double.Parse(Console.ReadLine());
Console.Write("Digite a segunda nota: ");
n2 = double.Parse(Console.ReadLine());
media = (n1 + n2) / 2;
if (media >= 60)
{
    Console.WriteLine("tirando {0} e {1} sua media é {2:N2}", n1, n2, media);
    Console.WriteLine("O aluno foi APROVADO.");
}
else
{
    Console.WriteLine("Tirando {0} e {1} sua media é {2:N2}", n1,n2,media);
    Console.WriteLine("O aluno foi REPROVADO");
}