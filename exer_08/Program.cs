using System.Data;

float metro, cent, mili;
Console.Write("Digite a quantidade de metros: ");
metro = float.Parse(Console.ReadLine());
cent = metro * 100;
mili = metro * 1000;
Console.WriteLine($"Q quantidade de metro foi {metro}\nA quantidade de centimetros é {cent}\nA quantidade de milimitros é {mili}");