+using System;

public class Paises
{

	public static void Main(string[] args)
	{

		string[][] arrMulti = RectangularArrays.RectangularStringArray(4, 4);
		string ax = "";
		Scanner ingresoTeclado = new Scanner(System.in);

		for (int i = 0;i < 4;i++)
		{
			Console.Write("Introduce el nombre del pais " + (i + 1) + " : ");
			arrMulti[i][0] = ingresoTeclado.nextLine() + ":";
		}
		for (int j = 0;j < 4;j++)
		{
			for (int i = 1;i < 4;i++)
			{
				Console.Write("Introduce el nombre de la ciudad " + (i) + " del pais " + (j + 1) + " : ");
				arrMulti[j][i] = ingresoTeclado.nextLine();
			}
		}
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				ax += arrMulti[i][j] + "        ";
			}
			ax += "\n";
		}
		Console.Write(ax);
	}
}

