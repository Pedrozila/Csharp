using System;

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, res;

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            res = num1 + num2;

            Console.WriteLine("A Soma é: " + res);

        }
    }
}
