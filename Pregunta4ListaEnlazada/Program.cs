using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pregunta4ListaEnlazada
{
    class Nodo
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Puesto { get; set; }

        public Nodo siguiente;

        public Nodo() { }
        public Nodo(string nombre, int edad, string puesto)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Puesto = puesto;
        }
        /*Constructor con insertacion al inicio y siguiente*/
        public Nodo(string nombre, int edad, string puesto, Nodo n)
        {
            Nombre = nombre;
            Edad = edad;
            Puesto = puesto;
            siguiente = n;
        }
    }
    class Lista
    {
        protected Nodo inicio, fin; //punteros de inicio y fin ->

        //constructor
        public Lista() {
            inicio = null;
            fin = null;
        }
        //Agregar un nodo al inicio de la lista
        public void AgregarAlInicio(string nombre, int edad, string puesto)
        {
            inicio = new Nodo(nombre, edad, puesto, inicio);

            if (fin == null)
            {
                fin = inicio;
            }
        }

        public void VaciarLista()
        {
            inicio = null;
        }
        public void MostrarLista()
        {
            Nodo recorrer = inicio; // nodo auxiliar
            while (recorrer != null)
            {
                Console.WriteLine("["+recorrer.Nombre+", "+recorrer.Edad+", "+recorrer.Puesto+"]");
                recorrer = recorrer.siguiente;
            }
        }

        public void BuscarNodo(string Nombre)
        {
            Nodo recorrer = inicio;
            while (recorrer != null)
            {
                if (Nombre == inicio.Nombre)
                {
                    Console.WriteLine("Se encontro el Nombre ["+ inicio.Nombre + "], Edad["+ inicio.Edad+ "], Puesto["+inicio.Puesto+"]\n");
                    inicio = inicio.siguiente;
                }
                else
                {
                    inicio = inicio.siguiente;
                }
                recorrer = recorrer.siguiente;
            }
        }

        public void GenerateTXT()
        {
            Nodo recorrer = inicio;
            string path = @"C:\Users\ALIEN10\Documents\FernandezGonzalezJulioAlberto\ExamenParadox\Examen31ParadoxReporte.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter outputFile = new StreamWriter(path))
                {
                    while (recorrer != null)
                    {
                        outputFile.WriteLine(recorrer.Nombre+ " "+recorrer.Edad+ " "+recorrer.Puesto);
                        recorrer = recorrer.siguiente;
                    }
                }
            }
            else
            {
                using (StreamWriter outputFile = new StreamWriter(path))
                {
                    while (recorrer != null)
                    {
                        outputFile.WriteLine(recorrer.Nombre + " " + recorrer.Edad + " " + recorrer.Puesto);
                        recorrer = recorrer.siguiente;
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Construya un programa para administrar una lista enlazada.*/
            Lista lista = new Lista();
            int opcion = 0;

            //lista.AgregarAlInicio("juan", 12, "generente");
            //lista.MostrarLista()
            do
            {
                try
                {
                    Console.WriteLine("\nIngresa una opcion.");
                    Console.WriteLine("1)	Llenar la lista desde un archivo.");
                    Console.WriteLine("2)	Salvar la lista a un archivo.");
                    Console.WriteLine("3)	Buscar un elemento en la lista en base a Nombre.");
                    Console.WriteLine("4)	Vaciar la lista.");
                    Console.WriteLine("5)	Mostrar lista.");
                    Console.WriteLine("0)	Salir.");
                    opcion = int.Parse(Console.ReadLine());
                    
                    switch (opcion)
                    {
                        case 1:
                            //llenado por medio de un archivo
                            string linea;
                            string[] Datos;
                            try
                            {
                                using (StreamReader file = new StreamReader(@"C:\Users\ALIEN10\Documents\FernandezGonzalezJulioAlberto\ExamenParadox\Examen31Paradox.txt"))
                                {
                                    while ((linea = file.ReadLine()) != null)
                                    {
                                        Datos = linea.Split('|');
                                       
                                        Nodo n = new Nodo();
                                        n.Nombre = Datos[0];
                                        n.Edad = int.Parse(Datos[1]);
                                        n.Puesto = Datos[2];
                                        lista.AgregarAlInicio(n.Nombre, n.Edad, n.Puesto);
                                    }

                                    file.Close();
                                }
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine("Error en " + e.Message);
                            }
                            break;

                        case 2:
                            //Guardar lista en un archivo txt
                            lista.GenerateTXT();
                            Console.WriteLine("Se genero el reporte en txt");
                            break;

                        case 3:
                            //Buscar un elemento en la lista en base a Nombre.
                            Console.WriteLine("Ingresa Nombre a buscar");
                            //string Nombre = Console.ReadLine();
                            lista.BuscarNodo(Console.ReadLine());
                            break;

                        case 4:
                            //vaciar lista
                            lista.VaciarLista();
                            break;
                        case 5:
                            lista.MostrarLista();
                            break;
                        case 0:
                            Environment.Exit(1);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error en " + e.Message);
                }
            } while (opcion != 0);

            Console.ReadKey();
        }
    }
}
