using System;

namespace Ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int res;

            res = (a * b) - (c * d);

            Console.WriteLine(res);

        }
    }
}
