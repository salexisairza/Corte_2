using System;

internal ublic class SumaMediaArrayApp
{

	public static void Main(string[] args)
	{

		//Creo un array
		int[] numeros = new int[100];

		//Declaro las variables necesarias
		int suma = 0;
		double media;

		//Recorro el array, asigno números y sumo
		for (int i = 0;i < numeros.Length;i++)
		{
			numeros[i] = i + 1;
			suma += numeros[i];
		}

		//Calculo la media y muestro la suma y la meda
		Console.WriteLine("La suma es " + suma);

		media = (double)suma / numeros.Length;

		Console.WriteLine("La media es " + media);

	}

}