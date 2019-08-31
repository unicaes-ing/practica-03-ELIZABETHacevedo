using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("digite una opcion [1-7]");
            opcion=System.Convert.ToInt32( Console.ReadLine());
            switch (opcion)
            {case 1:
                    Class1 c1 = new Class1();
                    c1.eje1();
                    break;
                case 2:
                    Class2 c2 = new Class2();
                    c2.eje1();
                    break;
                case 3:
                    Class3 c3 = new Class3();
                    c3.eje1();
                    break;
                case 4:
                    Class4 c4 = new Class4();
                    c4.eje1();
                    break;
                case 5:
                    Class5 c5 = new Class5();
                    c5.eje1();
                    break;
                case 6:
                    Class6 c6 = new Class6();
                    c6.eje1();
                    break;
                case 7:
                    Class7 c7 = new Class7();
                    c7.eje1();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
