double sal, prest, vr;
int anos;
Console.Write("Digite o valor do imovel: ");
vr = double.Parse(Console.ReadLine());
Console.Write("Digite o valor do Salario: ");
sal = double.Parse(Console.ReadLine());
Console.Write("Digite o tempo de quitaçao: ");
anos = int.Parse(Console.ReadLine());
prest = vr / (anos * 12);
if (prest >= (sal*30)/100)
{
    Console.WriteLine("Desculpe mais seu financiamento nao foi aprovado.");
    Console.WriteLine("Para pagar um imovel {0} em {1} anos, sua prestaçao {2:N2} deve ser acima de 30" +
        "% do seu salario", vr, anos, prest);
}
else
{
    Console.WriteLine("Seu financiamento foi aprovado sua prestaçao vai fica {0:n2}",prest);
}
