using System;
using System.Threading;

public class ejercicio3
{
/
  public static void Main(string[] args)
  { 

	int[][] num = {new int[6], new int[6], new int[6]}; 

	num[0][0] = 0;
	num[0][1] = 30;
	num[0][2] = 2;
	num[0][5] = 7;
	num[1][0] = 75;
	num[1][4] = 0;
	num[2][2] = -2;
	num[2][3] = 9;
	num[2][5] = 11;

	int fila;
	int columna;

	Console.Write("       ");
	for (columna = 0; columna < 6; columna++)
	{
	  Console.Write("   Columna " + columna);
	}
	for (fila = 0; fila < 3; fila++)
	{

	  Console.Write("\nFila " + fila);

	  for (columna = 0; columna < 6; columna++)
	  {
		Console.Write("{0,9:D}   ", num[fila][columna]);
		Thread.Sleep(500); // retardo de medio segundo
	  }
	}
  }
}
