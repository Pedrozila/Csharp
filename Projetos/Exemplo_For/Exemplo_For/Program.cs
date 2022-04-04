using System;

namespace Exemplo_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas vezes quer repetir? ");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;

            }
            Console.WriteLine("Soma = " + soma);
        }
    }
}
