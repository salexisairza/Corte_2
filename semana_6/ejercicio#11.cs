using System;
using System.Collections;


namespace ejerrcicio11
{

    public class ejercicio11
    {
        public static void Main()
        {
            int palabra;
            Stack Pila = new Stack();
            Queue miCola = new Queue(); 
            Queue miCola2 = new Queue();
         

            miCola.Enqueue(1);
            miCola.Enqueue(5);
            miCola.Enqueue(6);
            miCola.Enqueue(4);
            miCola.Enqueue(8);
            miCola.Enqueue(7);
            miCola.Enqueue(9);
        

            for (byte i = 0; i < 3; i++)
            {
                palabra = (int)miCola.Dequeue();  
                Console.WriteLine(palabra);
            }
            Console.ReadKey();
            while (miCola.Count > 0)
            {

                int Co = 0;
                Co = (int)miCola.Dequeue();
                Console.WriteLine($"  Cola: {Co}");
                Pila.Push(Co);
            }
           
            Console.WriteLine("La pila creada: ");
            while (Pila.Count > 0)
            {
                Console.WriteLine($"  Pila: {Pila.Pop()}");
            }

            miCola2.Enqueue(Pila);
            while (miCola2.Count > 0)
            {
                int cola;
                cola = (int)miCola2.Dequeue();
                Console.WriteLine(cola);
            }
        }

    }
}