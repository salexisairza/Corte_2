using System;

public class ejercicio2
{
  public static void Main(string[] args)
  {

/
	int[][] num = RectangularArrays.RectangularIntArray(4, 5);
	int fila;
	int columna;

	for (fila = 0; fila < 4; fila++)
	{
	  for (columna = 0; columna < 5; columna++)
	  {
		num[fila][columna] = (int)(GlobalRandom.NextDouble * 900) + 100;
	  }
	}

	
	int sumaFila;
	for (fila = 0; fila < 4; fila++)
	{
	  sumaFila = 0;
	  for (columna = 0; columna < 5; columna++)
	  {
		Console.Write("{0,7:D}   ", num[fila][columna]);
		sumaFila += num[fila][columna];
	  }
	  Console.Write("|{0,7:D}\n", sumaFila);
	}

	
	for (columna = 0; columna < 5; columna++)
	{
	  Console.Write("----------");
	}
	Console.WriteLine("-----------");

	int sumaColumna;
	int sumaTotal = 0;

	for (columna = 0; columna < 5; columna++)
	{
	  sumaColumna = 0;
	  for (fila = 0; fila < 4; fila++)
	  {
		sumaColumna += num[fila][columna];
	  }

	  sumaTotal += sumaColumna;
	  Console.Write("{0,7:D}   ", sumaColumna);
	}
	Console.Write("|{0,7:D}   ", sumaTotal);
  }


internal static class GlobalRandom
{
	private static System.Random randomInstance = null;

	public static double NextDouble
	{
		get
		{
			if (randomInstance == null)
				randomInstance = new System.Random();

			return randomInstance.NextDouble();
		}
	}
}


internal static class RectangularArrays
{
    public static int[][] RectangularIntArray(int size1, int size2)
    {
        int[][] newArray = new int[size1][];
        for (int array1 = 0; array1 < size1; array1++)
        {
            newArray[array1] = new int[size2];
        }

        return newArray;
    }
}
