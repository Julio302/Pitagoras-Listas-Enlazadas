using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParadox
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            /*Problema 1: Codifique una función que sume los enteros nones del 1 al 99 usando sentencias de control FOR, WHILE y DO WHILE.*/
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {

            //    }
            //    else
            //    {
            //        //Console.WriteLine("none " + i);
            //        cont += i;
            //    }
            //}

            //while
            //int i = 0;
            //while (i <= 100)
            //{
            //    if (i % 2 == 0)
            //    {

            //    }
            //    else
            //    {
            //        cont += i;
            //    }
            //    i++;
            //}


            //Do- While
            int i = 0;
            do
            {
                if (i % 2 == 0)
                {

                }
                else
                {
                    cont += i;
                }
                i++;

            } while (i <= 100);

            Console.WriteLine("Suma " + cont);
            Console.ReadKey();
        }
    }
}
