using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIMCDenovo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("informe seu peso atual: ");
            double peso = double.Parse(Console.ReadLine());

            altura = (altura * altura) / peso;

            if (altura <= 16.9)
            {
                Console.WriteLine("Muito abaixo do peso" );

            }
            else if (altura <= 18.4)
                 {
                 Console.WriteLine("Abaixo do peso" );

                 }
            else if (altura <= 24.9)
                 {
                 Console.WriteLine("Peso normal " );

                 }
            else if (altura <= 29.9)
                 {
                 Console.WriteLine("Acima do peso " );

                 }
            else if (altura <= 34.9)
                 {
                 Console.WriteLine("Obesidade I " );
                 }
            else if (altura <= 40)
                 {
                 Console.WriteLine("Obesidade II " );

                 }
            else if (altura > 40)
                 {
                 Console.WriteLine("Obesidade III " );

                 }





            Console.ReadKey();
        }
    }
}
