using System;

namespace Ex_10
{
    class Program
    {
        static void Main(string[] args)
        {

            int res;

            Console.WriteLine("Digite um numero: ");
            int x = int.Parse(Console.ReadLine());

            res = x % 2;

            if(res == 0)
            {
                Console.WriteLine("Numero par!!!");
            }
            else
            {
                Console.WriteLine("Numero impar!!!");
            }
        }
    }
}
