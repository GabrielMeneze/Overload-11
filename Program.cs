using System;

namespace Overload_11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cauculo cauculo = new Cauculo();

           
            System.Console.WriteLine( cauculo.Calcular() );

            
            System.Console.WriteLine( cauculo.Calcular(28000) );

            // Com 2 argumentos int
            System.Console.WriteLine( cauculo.Calcular(28000, 30000) );

            // Com 2 argumentos string
            System.Console.WriteLine( cauculo.Calcular("Oligac","Onsh") );

        }
    }
}
