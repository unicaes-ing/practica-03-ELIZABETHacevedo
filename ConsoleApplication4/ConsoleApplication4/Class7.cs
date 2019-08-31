using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Class7
    {
        public void eje1()
        {
            int opcion1,opcion2;

            //para lbs


            double onza2 = 0.0625, gramo2 = 0.00220462, tonelada2 = 2204.61999999999989;
            double datoEntrada, datoSalida=0;

            Console.WriteLine("dato de entrada \ngramo[1]\nonza[2]\nlibra[3]\ntonelada[4]");
            opcion1 = System.Convert.ToInt32(Console.ReadLine());
            //------------------------------------------------------------------------------------------------
            Console.WriteLine("ingrese medida:");
            datoEntrada = System.Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("dato de salida gramo[1]\nonza[2]\nlibra[3]\ntonelada[4]");
            opcion2 = System.Convert.ToInt32(Console.ReadLine());

            switch(opcion1)
            {
                case 1:
                    datoSalida = datoEntrada * gramo2;
                    break;
                case 2:
                    datoSalida = datoEntrada * onza2;
                    break;
                case 3:
                    datoSalida = datoEntrada;
                    break;
                case 4:
                    datoSalida = datoEntrada * tonelada2;
                    break;
                default:
                    break;
            }
            switch (opcion2)
            {
                case 1:
                    datoSalida = datoSalida / gramo2;
                    break;
                case 2:
                    datoSalida = datoSalida / onza2;
                    break;
                case 3:
                    break;
                case 4:
                    datoSalida = datoSalida / tonelada2;
                    break;
                default:
                    break;
            }
            Console.WriteLine(datoSalida);


            Console.ReadKey();

        }

        
    }
}
