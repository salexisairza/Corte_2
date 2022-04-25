using System;
using System.Collections;

namespace Ejercicio3_2
{
    class ejercicio3_2
    {
        static void mostrar(ArrayList Arreglo)
        {
            foreach (float i in Arreglo)
            {
                Console.WriteLine(" {0} ",i);
            }
            Console.WriteLine("\n--------------");
        }
        static void Main(string[] args)
        {
            ArrayList List1 = new ArrayList();
            Console.Write("Ingresa el tamaño de la lista");
            int l1=int.Parse(Console.ReadLine());
            for (int x=0; x<l1; x++)
            {
                Console.Write($"Ingresa el elemento {x + 1} de la primera lista: ");
                float valor=float.Parse(Console.ReadLine());
                List1.Insert(x, valor);
            }

            ArrayList List2 = new ArrayList(); 
            for (int c=0; c<l1; c++)
            {
                Console.Write($"Ingresa el elemento {c+1} de la segunda lista: ");
                float Num=float.Parse(Console.ReadLine());
                List2.Insert(c, Num);
            }
            Console.WriteLine("La concentracion de las dos listas es: ");
            List1.AddRange(List2); 
            mostrar(Lista1);
        }
    }
}