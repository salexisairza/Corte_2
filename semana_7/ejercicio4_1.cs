using System;
using System.Collections;

namespace Ejercicio4
{
    class ejercicio4
    {
        
        static void Main( string[] args)
        {
            
            Console.WriteLine("datos 1");
            ArrayList datos1 = new ArrayList();
            datos1.Add(2);
            datos1.Add(3);
            datos1.Add(4);
            datos1.Add(5);
            datos1.Add(6);

            datos1.Sort();

            imprimirArrayList(datos1);

            Console.WriteLine("datos 2");
            ArrayList datos2 = new ArrayList();
            datos2.Add(0);
            datos2.Add(1);
            datos2.Add(7);
            datos2.Add(8);
            datos2.Add(9);

            datos2.Sort();

            imprimirArrayList(datos2);

            Console.WriteLine("La concatenación de los datos es");
            datos1.AddRange(datos2);
            imprimirArrayList(datos1);




        }

        static void imprimirArrayList(ArrayList arreglo)
        {
            foreach(int i in arreglo)
                Console.WriteLine($" {i} ");
            Console.WriteLine("i--------");
        }

    }
}