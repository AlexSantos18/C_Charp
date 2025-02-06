internal class Program
{
    private static void Main(string[] args)
    {
        int n1, n2, n3;
        Console.Write("Digite um numero: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite um numero: ");
        n2 = int.Parse(Console.ReadLine());
        Console.Write("Digite um numero: ");
        n3 = int.Parse(Console.ReadLine());

        if (n1 < n2 && n1 < n3)
        {
            Console.WriteLine("menor {0}",n1);
            if (n2 > n3)
            {
                Console.WriteLine("maior {0}", n2);    
            }
            else
            {
                Console.WriteLine("maior {0}", n3);
            }

        }
        else if (n2 < n1 && n2 < n3)
        {
            Console.WriteLine("menor {0}",n2);
            if (n1 > n3)
            {
                Console.WriteLine("maior {0}", n1);
            }
            else
            {
                Console.WriteLine("maior {0}", n3);
            }

        }
        else if (n3 < n1 && n3 < n2)
        {
            Console.WriteLine("menor {0}",n3);
            if (n1 > n2)
            {
                Console.WriteLine("maior {0}", n1);
            }
            else
            {
                Console.WriteLine("maior {0}", n2);
            }
        }
        Console.ReadLine();
    }
}