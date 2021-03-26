using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta3Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Console.WriteLine("Ingresar una palabra");
            string palabra = Console.ReadLine();
            string palabrainvertida = "";
            foreach (char letras in palabra)
            {
                palabrainvertida = letras + palabrainvertida;
            }

            Console.WriteLine(palabrainvertida);

            if (palabra.Equals(palabrainvertida))
            {
                Console.WriteLine("La palabra "+palabra + " es palindromo");
            }
            else
            {
                Console.WriteLine("La palabra "+ palabra + " no es palindromo");
            }

            //char[] ch = palabra.ToCharArray();
            //Array.Reverse(ch);
            //Console.WriteLine(ch);

            //string palabraalreves = new string (ch);
            //bool t = palabra.Equals(palabraalreves, StringComparison.OrdinalIgnoreCase);

            //if (t == true)
            //{
            //    Console.WriteLine("La palabra "+ palabra + " es palindromo");
            //}
            //else
            //{
            //    Console.WriteLine("La palabra " + palabra + " No es palindromo ");
            //}
            
            Console.ReadKey();
        }
    }
}
