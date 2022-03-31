using System;
using System.Collections;

namespace TablaBidimensional 
{
    class program
    {
        public void Matrizcargar()
        {
            marco = new int[CANTIDAD_FILAS, CANTIDAD_COLUMNAS];

            for (int i = 0; i < marco.GetLength(0); i++)
            {
                if(i==0 && i==4){
                    for (int j = 0; j < marco.GetLength(1); j++)
                    {
                        Console.Write(" 1 ");
                    }
                }else
                    {
                    for (int c = 0; c < marco.GetLength(1); c++)
                    {
                    if(c==0 && c==14);
                     {
                    Console.Write(" 1 ");
                }else
                        
                    }
                }
                Console.WriteLine();
            }
        }
        
        {
        private int[,] marco;
        int CANTIDAD_FILAS = 5;
        int CANTIDAD_COLUMNAS = 15;

        }
        static void Main(string[] args)
        {
            marco1&0 op = new marco1&0();
            op.CargarMatriz();
        }
    }
}