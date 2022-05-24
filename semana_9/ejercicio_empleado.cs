using System;
using System.Collections;

namespace Ejercicio_Empleados
{
    class Empleados
    {
        private string nombre;
        private int sueldo;

        public Empleados()
        {
            Console.Write("Ingrese el nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese el sueldo: ");
            string linea = Console.ReadLine();
            sueldo = int.Parse(linea);
        }

        public void Imprimir()
        {
            Console.WriteLine("El nombre es: " + nombre);
            Console.WriteLine("El sueldo es de: " + sueldo);
        }

        public void Impuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("El empleado debe pagar impuesto");
            }
            else
            {
                Console.WriteLine("El empleado no debe pagar impuesto");
            }
        }
         
        static void Main(String[] args)
        {
            Empleados empleado1 = new Empleados();
            empleado1.Imprimir();
            empleado1.Impuestos();
            Console.WriteLine("");

            Empleados empleado2 = new Empleados();
            empleado2.Imprimir();
            empleado2.Impuestos();
            Console.WriteLine("");

            Empleados empleado3 = new Empleados();
            empleado3.Imprimir();
            empleado3.Impuestos();
            Console.ReadKey();
        }
    }
}