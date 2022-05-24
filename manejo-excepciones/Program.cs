using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejo_excepciones
{
    //Realizar la carga de un número entero por teclado e imprimir su cuadrado.
    //24-05-2022
    //Gutierrez Agaton Daniel
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            int Num;
            try
            {
              
                //Pedida de numero
                Console.Write("Dame un nuemro: ");
                Num = int.Parse(Console.ReadLine());

                Console.WriteLine("Elebado al cuadrado: " + Math.Pow(Num, 2));
            }
            

            catch(FormatException e)
            {
               Console.Write(e.Message);

            }
            catch(OverflowException )
            {
                Console.Write("El numero es demasiado grande para el formato");
            }
            Console.ReadKey();
        }
    }
}
