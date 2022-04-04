using System;

namespace Ex_7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double valorp1, valorp2, total;
            int cod1, cod2, qtd1, qtd2;

            string[] valores = Console.ReadLine().Split(' ');

            cod1 = int.Parse(valores[0]);
            qtd1 = int.Parse(valores[1]);
            valorp1 = double.Parse(valores[2]);

            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            qtd2 = int.Parse(valores[1]);
            valorp2 = double.Parse(valores[2]);

            total = (valorp1 * qtd1) + (valorp2 * qtd2);

            Console.WriteLine("Valor total a pagar: "+ total);

        }
    }
}
