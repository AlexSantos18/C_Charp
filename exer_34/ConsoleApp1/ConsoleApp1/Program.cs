double sal;
Console.Write("Digite o valor do Salario: ");
sal = double.Parse(Console.ReadLine());
if  (sal >= 1250.00)
{
    Console.WriteLine("O valor da correção é {0:N2}",sal *15/100);
    Console.WriteLine("O salario reajustado {0:N2}", sal + (sal * 15 / 100));
}
else
{
    Console.WriteLine("o valor da correçao é {0:N2}", sal * 10 / 100);
    Console.WriteLine("O salario reajustado {0:N2}", sal + (sal * 10 / 100));
}
Console.ReadLine();