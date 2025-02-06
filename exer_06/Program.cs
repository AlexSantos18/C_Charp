int n = 0;
//double resultado = 0; declarar a variavel double
Console.Write("digite um numero: ");
n = int.Parse(Console.ReadLine());
Console.WriteLine($"O dobro do numero {n} é {n*2}");
Console.WriteLine($"O triplo do numero {n} é {n*3}");
//resultado = Math.Sqrt(n); recebe a raiz quadrada da variavel 
Console.WriteLine($"A raiz quadrada do numero {n} é {Math.Sqrt(n)}"); // pode se fazer direto na expressao 
