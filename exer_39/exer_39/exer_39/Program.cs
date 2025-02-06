string data;
int ano,falta, resultado;
data = DateTime.Now.Year.ToString();
Console.Write("Digite o ano de nascimento: ");
ano = int.Parse(Console.ReadLine());
resultado = int.Parse(data) - ano;
falta = 18 - resultado;
if (resultado >= 18)
{
    ano = ano + 18;
    Console.WriteLine("Voce ja é maior de idade, seu alistamento foi em {0}", ano);
}
else
{
    Console.WriteLine("Quem nasceu em {0}, tem {1} anos em {2}", ano, resultado, data);
    Console.WriteLine("Ainda falta {0} anos para o alistamento.", falta);
    Console.WriteLine("Seu alistamento será em {0}.", int.Parse(data) + falta);
}

