using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Class2
    {
        public void eje1()
        {
            Random n = new Random();
            int v=n.Next(1,101);
            Console.WriteLine("numero : "+v);
            if (v % 2 == 0)
            {
                Console.WriteLine("es un numero par");
            }
            else
            {
                Console.WriteLine("es impar");
            }
            Console.ReadKey();
        }
    }
}
