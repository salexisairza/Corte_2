using System;

public static class Globals
{
	public static int n;
	public static int m;
	public static int num;
	public static int suma;
	public static float prom;
	internal static void Main()
	{
		Console.Write("arreglo bidimiendional \n");
		Console.Write("ingrese el numero de filas \n");
		string tempVar = ConsoleInput.ScanfRead();
		if (tempVar != null)
		{
			n = int.Parse(tempVar);
		}
		Console.Write("ingrese el numero de columnas \n");
		string tempVar2 = ConsoleInput.ScanfRead();
		if (tempVar2 != null)
		{
			m = int.Parse(tempVar2);
		}
		int[][] arreglo = RectangularArrays.RectangularIntArray(n, m);
		for (int i = 0;i < m;i++)
		{
			for (int j = 0;j < m; j++)
			{
			Console.Write("ingrese lo numeros enteros");
			string tempVar3 = ConsoleInput.ScanfRead();
			if (tempVar3 != null)
			{
				num = int.Parse(tempVar3);
			}
			arreglo[i][j] = num;
			suma = num + suma;
			}
		}
		Console.Write("el arreglo bidimiensional es el siguiente: \n");
		for (int i = 0;i < m;i++)
		{
			for (int j = 0;j < m; j++)
			{
				num = arreglo[i][j];
				Console.Write("{0:D} ",num);
				if (j == m - 1)
				{
					Console.Write("\n");
				}
			}
		}
		Console.Write("la suma de todos los numeros del arreglo bidimiensional es: {0:D}",suma);
		prom = (suma * 1.0) / (m * n);
		Console.Write("\n el promedio de los numeros del arreglo bidimensional es ; {0:f}",prom);
	}
}

