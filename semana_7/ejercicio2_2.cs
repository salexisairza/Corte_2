using System;
using System.Collections;

namespace Ejercicio2_2
{
    class Ejercicio2_2
    {

        static void Main(string[] args)
        {

            ArrayList datos1 = new ArrayList();
            datos1.Add(2);
            datos1.Add(3);
            datos1.Add(4);
            datos1.Add(5);
            datos1.Add(6);

            datos1.Sort();

            Console.WriteLine("El arreglo es: ");
            imprimirArrayList(datos1);

            datos1.Insert(0, 5);
            datos1.Insert(1, 10);
            datos1.Insert(2, 15);
            datos1.Insert(3, 20);
            datos1.Insert(4, 25);

            datos1.Reverse();

            imprimirArrayList(datos1);

            datos1.Remove(0);
            datos1.Remove(1);
            datos1.Remove(2);
            datos1.Remove(3);
            datos1.Remove(4);

            datos1.Sort();



        }

        static void imprimirArrayList(ArrayList arreglo)
        {
            foreach(int i in arreglo)
                Console.WriteLine($" {i} ");
            Console.WriteLine("i--------");
        }

    }
}