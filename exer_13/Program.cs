double sal;
Console.Write("Qual o valor do salario: ");
sal = double.Parse(Console.ReadLine());
Console.WriteLine("O valor do novo salario com 15% de acrecimo é {0:N2}", sal + (sal*15/100) ); 
