int lar, alt, total;
Console.Write("Qual a largura da parede: ");
lar = int.Parse(Console.ReadLine());
Console.Write("Qual a altura da parede: ");
alt = int.Parse(Console.ReadLine());
total = lar * alt;
Console.WriteLine("A area total da parede {0} voce precisara de {1} litros de tintas para pintar.",total, total/2);