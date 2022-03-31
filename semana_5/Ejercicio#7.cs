using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace CensoFamiliar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            int l = 0;

            int g = 0;

            int e = 0;

            Console.WriteLine("Digite el precio del recibo del agua");
            
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el precio del recibo de la luz");
            
            l = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el precio del recibo del gas");
            
            g = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el estrato al que pertenece");
            
            e = int.Parse(Console.ReadLine());

            double costoA = 0;

            double costoL = 0;

            double costoG = 0;

            double costoT = 0;

            if 

            e == 1
            {
                costoL = l - (l * descuento1);
                costoA = a - (a * descuento1);
                costoG = g - (g * descuento1);

            
            (costoT = costoA + costoL + costoG);
            }

            if 

            e == 2
            {
                costoA = a - (a * descuento2);
                costoL = l - (l * descuento2);
                costoG = g - (g * descuento2);
    

            (costoT = costoA + costoL + costoG);
            }

            if 

            e == 3
            {
                costoG = a - (a * descuento3);
                costoL = l - (l * descuento3);
                costoA = g - (g * descuento3);
            

            (costoT = costoA + costoL + costoG);
            }

            double descuento1 = 0.20;

            double descuento2 = 0.15;

            double descuento3 = 0.09;


            Console.WriteLine ("El costo a pagar por el recibo del agua es [0]:", costoA);
            Console.WriteLine ("El costo a pagar por el recibo de la luz es {0}:", costoL);
            Console.WriteLine ("El costo a pagar por el recibo del gas es {0}:", costoG);

        }
    } Console.WriteLine ("El costo a pagar por todos los recibos es {0}:", costoT);

}