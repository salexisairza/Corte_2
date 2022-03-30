using System;

public static class Globals
{
	internal static void Main(string[] args)
	{
	int[][] matriz = RectangularArrays.RectangularIntArray(DefineConstants.MAX, DefineConstants.MAX);
	int col;
	int reng;
	int i = 0;
	int j = 0;
	  Console.Write("Cuantas columnas quieres ");
	  string tempVar = ConsoleInput.ScanfRead();
	  if (tempVar != null)
	  {
		  col = int.Parse(tempVar);
	  }
	  Console.Write("Cuantos renglones quieres ");
	  string tempVar2 = ConsoleInput.ScanfRead();
	  if (tempVar2 != null)
	  {
		  reng = int.Parse(tempVar2);
	  }
	  for (i = 0;i < reng;i++) //RUTINA PARA LEER LOS DATOS
	  {
		  for (j = 0;j < col;j++)
		  {
			  Console.Write("ESCRIBE LOS VALORES [{0:D}][{1:D}]==>\t", i + 1, j + 1);
				  string tempVar3 = ConsoleInput.ScanfRead();
				  if (tempVar3 != null)
				  {
					  matriz[i][j] = int.Parse(tempVar3);
				  }
		  }
	  }
	  Console.Write("\n\n\t\tMatriz original"); //RUTINA PARA IMPRIMIR
	  Console.Write("\n\n");
	  for (i = 0;i < reng;i++)
	  {
		  Console.Write("\n\t\t");
		  for (j = 0;j < col;j++)
		  {
			  Console.Write("  {0,6:D}  ", matriz[i][j]);
		  }
	  }
	  Console.Write("\n\n\t\tMatriz transpuesta"); //IMPRIMIR MATRIZ TRANSPUESTA
	  Console.Write("\n\n");
	  for (i = 0;i < col;i++)
	  {
		  Console.Write("\n\t\t");
		  for (j = 0;j < reng;j++)
		  {
			  Console.Write("  {0,6:D}  ", matriz[j][i]);
		  }
	  }
	  Console.Write("\n\n\n");
	}
}

internal static class DefineConstants
{
	public const int MAX = 10;
}

