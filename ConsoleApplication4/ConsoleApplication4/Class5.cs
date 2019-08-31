using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Class5
    {
        public void eje1()
        {
            int numero;
            Console.WriteLine("ingrese un numero entre 1-10:");
            numero = System.Convert.ToInt32(Console.ReadLine());
            switch (numero)


            {
                case 1:
                    Console.WriteLine("uno");
                    break;
                case 2:
                    Console.WriteLine("dos");
                    break;
                case 3:
                    Console.WriteLine("tres");
                    break;
                case 4:
                    Console.WriteLine("cuatro");
                    break;
                case 5:
                    Console.WriteLine("cinco");
                    break;
                case 6:
                    Console.WriteLine("seis");
                    break;
                case 7:
                    Console.WriteLine("siete");
                    break;
                case 8:
                    Console.WriteLine("ocho");
                    break;
                case 9:
                    Console.WriteLine("nueve");
                    break;
                case 10:
                    Console.WriteLine("diez");
                    break;

                default:
                    Console.WriteLine(":(");
                    break;
            }
        }
    }
}
