using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta2Pitagoras
{
    class Triangulo
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangulo(double a, double b)
        {
            this.A = a;
            this.B = b;
        }
    }
    class TrianguloRectangulo : Triangulo
    {
        public double C;
        TrianguloRectangulo(double a, double b)
            : base(a, b)
        {
            C = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }

        static void Main(string[] args)
        {
            /*
            Problema 2: Construya el programa para resolver el Teorema de Pitágoras (c2=a2+b2).
                I) Construya una clase padre Triángulo y una clase heredada Triángulo Rectángulo.
                II) Incluya las propiedades de cada variable.
                III) Muestre el uso de this y base.
                IV) Implemente validaciones sobre valores y cálculos.
             * 
             * https://www.problemasyecuaciones.com/Pitagoras/problemas-resueltos-teorema-pitagoras-tringulo-rectangulo-secundaria.html
            */
            try
            {

                double a = 0;
                double b = 0;

                Console.WriteLine("Ingresa a");
                a = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa b");
                b = double.Parse(Console.ReadLine());

                if (a == 0 || b == 0)
                {
                    Console.WriteLine("A y B deben ser mayor a 0");
                    Environment.Exit(1);
                }

                TrianguloRectangulo t = new TrianguloRectangulo(a, b);
                Console.WriteLine("Respuesta " + t.C);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
