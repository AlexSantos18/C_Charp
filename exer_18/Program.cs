double n, sen, coss, tan;
Console.Write("Digite um Angulo: ");
n = double.Parse(Console.ReadLine());
sen = Math.Sin(n);
coss = Math.Cos(n);
tan = Math.Tan(n);
Console.WriteLine("O angulo de {0}\nO Seno {1:N2}\nO Cosseno {2:N2}\nA Tangente {3:N2}.",n,sen,coss,tan);