using System;

namespace Ex_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("Digite o codigo do produto: ");
            Console.WriteLine("1. Alcool, 2.Gasolina, 3.Diesel, 4.Fim");
            int cod = int.Parse(Console.ReadLine());

            while(cod != 4)
            {
                if(cod == 1)
                {
                    alcool = alcool + 1;
                }
                else if(cod == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if(cod == 3)
                {
                    diesel = diesel + 1;
                }

                Console.WriteLine("Digite o codigo novamente: ");
                cod = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
