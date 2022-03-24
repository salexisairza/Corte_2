using System;

public class arrayApp
{

	public static void Main(string[] args)
	{

		//Esto es opcional
		const int TAMANIO = 10;

		int[] num = new int[TAMANIO];

		//Invocamos las funciones
		rellenarArray(num);

		mostrarArray(num);
	}

	public static void rellenarArray(int[] lista)
	{
		for (int i = 0;i < lista.Length;i++)
		{
			string texto = JOptionPane.showInputDialog("Introduce un número");
			lista[i] = int.Parse(texto);
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
