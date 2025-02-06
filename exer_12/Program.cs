float vr;
Console.Write("Qual o preço do produto: ");
vr = float.Parse(Console.ReadLine());
Console.WriteLine("O produto avista tem 5% de desconto ficando {0:N2} o preço do produto.", (vr-(vr *5)/100));