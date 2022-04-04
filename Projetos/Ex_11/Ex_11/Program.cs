using System;

namespace Ex_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int res;

            Console.WriteLine("digite um numero: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());

            if(a % b == 0 || b % a == 0)
            {
                Console.WriteLine("são multiplos!!!");
            }
            else
            {
                Console.WriteLine("não são multiplos");
            }
        }
    }
}
