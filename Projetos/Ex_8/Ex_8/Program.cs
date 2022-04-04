using System;
using System.Globalization;

namespace Ex_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, areaT, areaC, areaTr, areaQ, areaR;

            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            areaT = (a * c) / 2.0;
            areaC = 3.14 * c * c;
            areaTr = (a + b) / (2.0 * c);
            areaQ = b * b;
            areaR = a * b;

            Console.WriteLine(areaT);
            Console.WriteLine(areaC);
            Console.WriteLine(areaTr);
            Console.WriteLine(areaQ);
            Console.WriteLine(areaR);

            

            
        }
    }
}
