using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Class4
    {
        public void eje1()
        {
            /*TimeSpan minutos;
            string min;
            Console.WriteLine("duracion de la llamada:");
            
            minutos = TimeSpan.Parse(Console.ReadLine());
            Console.WriteLine(minutos);
            Console.ReadKey();
            */

            int minutos,opcion;
            double total=0;
            Console.WriteLine("duracion de la llamada[minutos]:");
            minutos = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el area\n[1]zona occidental\n[2]zona central\n[3]zona oriental");
            opcion = System.Convert.ToInt32(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                    total = minutos * 0.32;
                    break;
                case 2:
                    total = minutos * 0.25;
                    break;
                case 3:
                    total = minutos * 0.36;
                    break;
                default:
                    break;
            }
            if (total > 0)
            {
                Console.WriteLine("Total a pagar: " + total.ToString("C2"));
                            }
            else
            {
                Console.WriteLine("datos erroneos");
            }
            Console.ReadKey();
        }
    }
}
