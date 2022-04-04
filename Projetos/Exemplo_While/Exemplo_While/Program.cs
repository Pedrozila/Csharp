using System;

namespace Exemplo_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            double x = double.Parse(Console.ReadLine());

            while(x >= 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz);

                Console.WriteLine("digite outro numero: ");
                x = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("numero invalido");
        }
    }
}
