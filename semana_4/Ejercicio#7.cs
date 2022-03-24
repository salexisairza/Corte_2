using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace notasEstudiantes
{
    class program
    {
        {
        int nombres; int dimensionVector = 12;
        string[]nombre; double Nota1;
        }        
        public void Operaciones()
        {

            {

             double Nota = 0; 
            
             for (int k = 0; k < nombre.Length; k++);

             nombre=new string[dimensionVector];
            
            }

            {
                 {
                     Console.WriteLine("Nombre del Estudiante:");
                     nombres = (Console.ReadLine());

                     Console.WriteLine("Ingrese una nota entre 0 y 10:");
                     nota = double.Parse(Console.ReadLine());
                 }
                     
            
               
                    if (nota < 4,99)     
                    
                        Console.WriteLine ("INSUFICIENTE");
                    

                    if (nota >= 5 && nota < 6,99)
                    
                        Console.WriteLine("ACEPTABLE");
                    
                        
                    if (nota >= 7 && nota < 8,99)
                    
                        Console.WriteLine("SOBRESALIENTE");
                    

                    if (nota >= 9 && nota <= 10)
                    
                        Console.WriteLine("EXCELENTE"); 
                
               
                Console.WriteLine("El estudiante" + nombres + "obtuvo una nota de"+ nota);
                
            }    
        }
    }
}