using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace alturaPersonasMedia
{
    class program
    {
        double[] alturaGeneral;
        public void Calculos ()
        {

             int personas;

             double suma = 0; 
                    Altura1 = 0; 
                    promedio = 0;
            
            {

             Console.WriteLine("Ingrese el numero de personas:");
             double[] altura = new double[personas];
             personas = int.Parse(System.Console.ReadLine());

            }

             for (int j = 0; j < personas; j++)
            
            {

                Console.WriteLine("ingrese la altura:");
                suma = ((suma+altura)[j]);
                promedio = suma / personas;
                altura[j] = double.Parse(System.Console.ReadLine());
            
            }

            for (int i = 0; i < personas; i++)

                        Console.WriteLine("Media:" + promedio);
                        Array.Sort(altura);

            Console.WriteLine ("El menor es: " + altura [0]);

            Console.WriteLine ("El mayor es: " + altura [personas - 1]);

        }
    }
}