using System;
using System.Globalization;

namespace App_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*conversao implicita de dados
             float x = 4.5f;
             double y = x;
             
             variavel double (y) recebe um valor float (x)
            */
            
            
  
            sbyte x = 100;
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "maria";

            //placeholders
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais ", nome, idade, saldo);

            //interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais ");

            //contenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais ");




            /*
            //formas de saida de dados
            Console.WriteLine(x);
            Console.Write("Bom Dia");
            Console.WriteLine("Boa Tarde");
            Console.WriteLine("Boa Noite");
            Console.WriteLine("---------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            //quantidade de casas depois da virgula
            Console.WriteLine(saldo.ToString("F2")); 
            Console.WriteLine(saldo.ToString("F4"));
            //trocas virgula do decimal por ponto
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
            */


        }
    }
}
 