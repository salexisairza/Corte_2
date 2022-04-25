using System;
using System.Collections;

namespace Ejercicio1
{
    class program
    {
        static void Main(String[] args)
        {
            Queue cola1 = new Queue();
            Queue cola2 = new Queue();
            int n = 0;

            Console.WriteLine("Ingrese los valores que quiere que tenga la cola: ");
            while(true)
            {
                n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    Console.WriteLine("Se ingresó el número 0, fin del programa");
                    break;
                }
                cola1.Enqueue(n);
            }
            ArrayList arreglo = new ArrayList();
            Console.WriteLine("\n cola:");

            while(cola1.Count > 0)
            {
                int p = 0;
                p = (int)cola1.Dequeue();
                Console.WriteLine("(" + p + ")");
                arreglo.Add(p);
            }
            arreglo.Sort();

            Console.WriteLine("\n La cola de manera ordenada es: ");
            foreach (int i in arreglo)
            {
                cola1.Enqueue(i);
                Console.WriteLine("(" + cola1.Dequeue() + ")");
            }
        }
    }
}