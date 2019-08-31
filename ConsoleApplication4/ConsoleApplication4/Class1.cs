using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Class1
    {
        public void eje1()
        {
            int hora;


            Console.WriteLine("ingresar horas transcurridas:");
            hora = System.Convert.ToInt32( Console.ReadLine());
            if (hora > 0)
            {
                Console.WriteLine("minutos= " + (hora * 60));
                Console.WriteLine("segundos= " + (hora * 3600));
            }else
            {
                Console.WriteLine("el dato ingresado es negativo:(");
            }
            Console.ReadKey();

        }


    }
}
