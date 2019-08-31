using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Class3
    {
        public void eje1()
        {
            int num1, num2, num3;
            Console.WriteLine("ingrese un numero: ");
            num1 = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese otro numero: ");
            num2 = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese otro numero: ");
            num3 = System.Convert.ToInt32(Console.ReadLine());

            if (num1 <= num2)
            {
                if (num2 <= num3)
                {
                    Console.WriteLine(num1 + "--" + num2 + "--" + num3);
                }
                else
                {
                    if (num1<=num3)
                    {
                        Console.WriteLine(num1 + "--" + num3 + "" + num2);
                    }
                    else
                    {
                        Console.WriteLine(num3 + "--" + num1 + "--" + num2);
                    }
                }

            }
            else
            {
                if (num2<=num3)
                {
                    if(num1>=num3)
                    {
                        Console.WriteLine(num2 + "--" + num3 + "" + num1);
                    }
                    else
                    {
                        Console.WriteLine(num2 + "--" + num1 + "--" + num3);
                    }
                }
                else
                {
                    
                    Console.WriteLine(num3 + "--" + num2 + "--" + num1);
                }
            }
           


            
            
            Console.ReadKey();

        }
    }
}
