using System;

namespace Juros
{
    class Program
    {
        static void Main(string[] args)
        {
            double c,j,t,i,ix,m;

            

            Console.Write("Qual é o seu capital: ");
            c = double.Parse(Console.ReadLine());

            Console.Write("Qual a taxa do juro: ");
            i = double.Parse(Console.ReadLine());
            Console.WriteLine();
            ix= i/100;

            
            Console.Write("Quanto tempo em meses : ");
            t = double.Parse(Console.ReadLine());
            Console.WriteLine(); 

            j= c * ix* t;

            m = c + j;
            Console.WriteLine($"Seu montate final é de  = {m}");
            Console.WriteLine();
        }
    }
}
