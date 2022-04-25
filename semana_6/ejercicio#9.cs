using System;
using System.Collections;

namespace Ejercicio9
{
    class ejercicio9
    {
        static void mostrar(ArrayList Arreglo)
        {
            foreach(int x in Arreglo){
                Console.WriteLine(x);
            }
            Console.WriteLine("--------------");
        }
        static void Main(string[] args)
        {
            ArrayList List1=new ArrayList();
            Console.Write("Ingresa el tamaño de la lista");
            int a=int.Parse(Console.ReadLine());
             for(int b=0; b<a; b++){
                Console.Write($"Digite el elemento {b+1}: ");
                int valor=int.Parse(Console.ReadLine());
                List1.Insert(b,valor);
            }
            mostrar(List1);
        }
    }
}