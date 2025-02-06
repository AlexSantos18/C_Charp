string date;
int nasc, resolt;
date = DateTime.Now.Year.ToString();
Console.Write("Digite o ano de nascimento: ");
nasc = int.Parse(Console.ReadLine());
resolt = int.Parse(date) -nasc;
switch (resolt)
{
    case <= 9:
        {
            Console.WriteLine("O atleta tem {0} anos.", resolt);
            Console.WriteLine("Classificação : MIRIM");
            break;
        }
    case <= 14:
        {
            Console.WriteLine("O atleta tem {0} anos.", resolt);
            Console.WriteLine("Classificação : INFANTIL");
            break;
        }
    case <= 19:
        {
            Console.WriteLine("O atleta tem {0} anos.", resolt);
            Console.WriteLine("Classificação : JUNIOR");
            break;
        }
    case <= 25:
        {
            Console.WriteLine("O atleta tem {0} anos.", resolt);
            Console.WriteLine("Classificação : SENIOR");
            break;
        }
    default:
        {
            Console.WriteLine("O atleta tem {0} anos. ", resolt);
            Console.WriteLine("Classificação : MASTER");
            break;
        }
}