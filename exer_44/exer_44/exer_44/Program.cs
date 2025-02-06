int i = 0;
while (i <= 5 ) 
{ 
    Console.Clear();
    double vr, juros, vr_total, vr_total_parc;
    int op, parc;
    Console.WriteLine("=========== LOJAS SANTOS ============");
    Console.Write("Qual o valor da Compras R$: ");
    vr = double.Parse(Console.ReadLine());
    Console.WriteLine("[ 1 ] à Vista Dinheiro/Pix");
    Console.WriteLine("[ 2 ] à Vista com Cartão");
    Console.WriteLine("[ 3 ] 2x no Cartao Credito");
    Console.WriteLine("[ 4 ] 3x ou mais no Cartao");
    Console.WriteLine("[ 5 ] Cancelar Compra");
    Console.WriteLine("[ 6 ] Fechar a Loja");
    Console.Write("Escolha uma forma de Pagamento: ");
    op = int.Parse(Console.ReadLine());
    if  (op >= 5)
    {
        if (op == 5)
        {
            Console.WriteLine("COMPRA CANCELADA");
            Console.ReadLine();
            i = op;
        }
        else
        {
            Console.WriteLine("LOJA FECHADA");
            i = op;
            Console.ReadLine();
        }
    }

        switch (op)
        {
            case 1:
                juros = (vr * 10) / 100;
                vr_total = vr - juros;
                Console.WriteLine("Suas compras à Vista Dinheiro/Pix tem 10% de desconto no valor R$ {0:n2}.", juros);
                Console.WriteLine("O valor a pagar é R$ {0:n2}", vr_total);
                Console.ReadLine();
                break;
            case 2:
                juros = (vr * 5) / 100;
                vr_total = vr - juros;
                Console.WriteLine("Suas compras à Vista com Cartão tem 5% de desconto no valor R$ {0:n2}.", juros);
                Console.WriteLine("O valor a pagar é R$ {0:n2}", vr_total);
                Console.ReadLine();
                break;
            case 3:
                vr_total_parc = vr / 2;
                Console.WriteLine("O valor das parcelas será R$ {0:n2} e o valor total R$ {1:n2}",vr_total_parc, vr );
                
                Console.ReadLine();

                break;
            case 4:
                Console.Write("Qual a quantidade de parcelas: ");
                parc = int.Parse(Console.ReadLine());
                juros = (vr * 20) / 100;
                vr_total = vr + juros;
                vr_total_parc = vr_total / parc;
                Console.WriteLine("Suas compras parceladas em {0} tem um acrescimo de 20% no valor R$ {1:n2}", parc, juros);
                Console.WriteLine("O valor das parcela será R$ {0:n2} e o valor total R$ {1:n2}", vr_total_parc, vr_total);
                Console.ReadLine();    
            break;
           
            
          
    }
    
}
