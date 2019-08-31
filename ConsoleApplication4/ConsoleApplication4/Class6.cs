using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Class6
    {
        
        public void eje1()
        {
            double compra,descuento=0;
            Console.WriteLine("total:");
            compra = System.Convert.ToDouble(Console.ReadLine());
            if (compra > 0)
            {
                if (compra > 500)
                {
                    descuento = compra * 0.20;

                } else if (compra > 200)
                {
                    descuento = compra * 0.15;
                } else if (compra > 100)
                {
                    descuento = compra * 0.12;
                }
                else {
                    descuento = 0;
            } }
            compra = compra - descuento;
            Console.WriteLine("Descuento: "+descuento.ToString("C2"));
            Console.WriteLine("total :"+compra.ToString("C2"));
            Console.ReadKey();
        }
    }
}
