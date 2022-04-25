using System;
using System.Collections;
using System.Linq;
namespace Ejercicio8
{
    class Ejercicio8
    { 
        ArrayList List1 = new ArrayList();
        ArrayList List2 = new ArrayList();
        ArrayList List3 = new ArrayList();
        Random R =new Random();
        public void cargar()
        {
            Console.WriteLine("Ingresa el tamaño de las listas");
            int A = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < t; i++)
            {
                List1.Add(rdn.Next(1,10));
                List2.Add(rdn.Next(10,20));
            }
            Console.WriteLine("La Lista 1 La Conforman Los Elementos: ");
            foreach (int X in List1)
            {
                Console.Write($"{X}| ");
            }
            Console.WriteLine("La Lista 2 La Conforman Los Elementos: ");
            foreach (int X in List2)
            {
                Console.Write($"{X}| ");
            }
            Console.WriteLine();
        }
        public void operar()
        {
          List=List1;
          List1=List2;
          List2=List;
          Console.WriteLine("la Lista 1 termino con los elementos: ");
            foreach (int X in List1)
            {
                Console.Write($"{X}| ");
            }
            Console.WriteLine("la Lista 2 termino con los elementos: ");
            foreach (int X in List2)
            {
                Console.Write($"{X}| ");
            }
        }
        static void Main(string []args)
        {
         Program OP = new Program();
         OP.cargar();
         OP.operar();
        }
    }
}