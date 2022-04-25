using System;
using System.Collections;
namespace ejercicio4;
{
    class   ejercicio4
    { 
        
         vacío  estático principal ( cadena [] args )
        {
            
            consola _ WriteLine ( " datos 1 " );
            ArrayList  datos1  =  new  ArrayList ();
            datos1 . Añadir ( 0 );
            datos1 . Añadir ( 6 );
            datos1 . Añadir ( 7 );
            datos1 . Añadir ( 5 );
            datos1 . Añadir ( 4 );

            datos1 . Ordenar ();

            imprimirArrayList ( datos1 );

            consola _ WriteLine ( " datos 2 " );
            ArrayList  datos2  =  new  ArrayList ();
            datos2 . Añadir ( 0 );
            datos2 . Añadir ( 7 );
            datos2 . Añadir ( 7 );
            datos2 . Añadir ( 5 );
            datos2 . Añadir ( 7 );

            datos2 . Ordenar ();

            imprimirArrayList ( datos2 );

            consola _ WriteLine ( " La concatenación de los datos es " );
            datos1 . AddRange ( datos2 );
            imprimirArrayList ( datos1 );




        }

        static  void  imprimirArrayList ( ArrayList  arreglo )
        {
            foreach ( int  i  en  arreglo )
                consola _ WriteLine ( $" { i } " );
            consola _ WriteLine ( " i-------- " );
        }

    }
}