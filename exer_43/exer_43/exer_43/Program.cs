double peso, altura, imc;
Console.Write("Digite o seu peso: ");
peso = double.Parse(Console.ReadLine());
Console.Write("Digite a sua altura: ");
altura = double.Parse(Console.ReadLine());
imc = peso / (altura *  altura);
switch (imc)
{
    case (<= 18.5):
        Console.WriteLine("O imc dessa pessoa é de {0:n2}", imc);
        Console.WriteLine("Voce está abaixo do normal (PROCURE UM MEDICO)");
        break;
    case <= 24.9:
        Console.WriteLine("O imc dessa pessoa é de {0:n2}.", imc);
        Console.WriteLine("Voce esta normal");
        break;
    case <= 29.9:
        Console.WriteLine("O imc dessa pessoa é de {0:n2}.",imc);
        Console.WriteLine("Voce esta com sobrepeso.");
        break;
    case <= 34.9:
        Console.WriteLine("O imc dessa pessoa é de {0:n2}.", imc);
        Console.WriteLine("Voce esta com obsidade GRAU I.");
        break;
    case <= 39.9:
        Console.WriteLine("O imc dessa pessoa é de {0:n2}.", imc);
        Console.WriteLine("Voce esta com obsidade GRAU II.");
        break;
    default:
        Console.WriteLine("O imc dessa pessoa é de {0:n2}.", imc);
        Console.WriteLine("Voce está com obsidade com GRAU III (SINAL VERMELHO");
        break;

}

