using System;

namespace Ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double raio;
            double res;

            raio = 3.14;

            res = raio * (Math.Pow(num1, 2));

            Console.WriteLine(res.ToString("f4"));

        }
    }
}
