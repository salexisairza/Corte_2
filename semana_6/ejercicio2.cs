using System;
using System.Collections;

namespace Ejercicio2
{
    class program
    {
        static void Main(String[] args)
        {
            ArrayList Datos = new ArrayList();

            Console.WriteLine("La lista es: ");
            Datos.Add(70);
            Datos.Add(200);
            Datos.Add(46);
            Datos.Add(153);
            Datos.Add(8);
            Datos.Add(53);
            Datos.Add(24);
            Datos.Add(10);
            Datos.Add(18);
            Datos.Add(86);
            ImprimirDatosLista(Datos);

            Console.WriteLine("Los números ingresados elevados al cuadrado son: ");
            ElevadoDatosLista(Datos);

            Console.WriteLine("La suma de los números elevados al cuadrado es de: ");
            SumaDatosLista(Datos);
        }
        static void ImprimirDatosLista(ArrayList arreglo)
        {
            foreach (int p in arreglo)
                Console.Write($" {p} ");
            Console.WriteLine("\n--------");
        }
        
        static void ElevadoDatosLista(ArrayList arreglo)
        {
            foreach (int p in arreglo)
                Console.Write(" {0}", p * p);
            Console.WriteLine("\n---------");
        }

        static void SumaDatosLista(ArrayList arreglo)
        {
            int Datos = 0;
            foreach (int p in arreglo)
                Datos = Datos + (p * p);
            Console.WriteLine("{0}", Datos);
            Console.WriteLine("\n---------");

        }
    }
}