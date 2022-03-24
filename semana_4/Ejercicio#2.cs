using System;

public class arrayNumAleatoriosApp
{

	public static void Main(string[] args)
	{

		//Indicamos el tamaño
		string texto = JOptionPane.showInputDialog("Introduce un tamaño");
		int[] num = new int[int.Parse(texto)];

		//Invocamos las funciones
		rellenarNumAleatorioArray(num, 0, 9);

		mostrarArray(num);
	}

	public static void rellenarNumAleatorioArray(int[] lista, int a, int b)
	{
		for (int i = 0;i < lista.Length;i++)
		{
			//Generamos un número entre los parametros pasados
			lista[i] = ((int)Math.Floor(GlobalRandom.NextDouble * (a - b) + b));
		}
	}

	public static void mostrarArray(int[] lista)
	{
		for (int i = 0;i < lista.Length;i++)
		{
			Console.WriteLine("En el indice " + i + " esta el valor " + lista[i]);
		}
	}
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