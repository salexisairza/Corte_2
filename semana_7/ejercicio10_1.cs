using System;
using System.Collections;

namespace Ejercicio10
{
    class program
    {
        static void Main(String[] args)
        {
            Queue Colanum1 = new Queue();
            Queue Colanum2 = new Queue();
            Queue Colanum3 = new Queue();

            Colanum1.Enqueue(24);
            Colanum1.Enqueue(28);
            Colanum1.Enqueue(32);
            Colanum1.Enqueue(36);
            Colanum1.Enqueue(40);
            Colanum1.Enqueue(44);

            Colanum2.Enqueue(48);
            Colanum2.Enqueue(52);
            Colanum2.Enqueue(56);
            Colanum2.Enqueue(60);
            Colanum2.Enqueue(64);
            Colanum2.Enqueue(68);

            Console.WriteLine("Primera Cola");
            Console.WriteLine();

            while (Colanum1.Count > 0)
            {
                int col = 0;
                col = (int) Colanum1.Dequeue();
                Console.Write("[" + col + "]");
                Colanum3.Enqueue(col);
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Segunda Cola");
            Console.WriteLine();

            while (Colanum2.Count > 0)
            {
                int col = 0;
                col = (int) Colanum2.Dequeue();
                Console.Write("[" + col + "]");
                Colanum3.Enqueue(col);
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Concatenación de la Primera y segunda cola");
            Console.WriteLine();

            while (Colanum3.Count > 0)
            {
                int col = 0;
                col = (int)Colanum3.Dequeue();
                Console.Write("[" + col + "]");
            }
            Console.WriteLine();
        }
    }
}