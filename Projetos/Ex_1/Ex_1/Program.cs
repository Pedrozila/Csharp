using System;
using System.Globalization;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computado";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.0;
            double medida = 53.234567;


            //saidas 
            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1}, cujo preco é ${preco1}");
            Console.WriteLine($"{produto2}, cujo preco é ${preco2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, codigo {5290} e genero {genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (tres casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture:" + medida.ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}
