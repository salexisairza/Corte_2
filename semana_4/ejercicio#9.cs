using System;

Scanner sc = new Scanner(System.in);
	int aux, aux2;
	int cont = 0;
	int comprobaciones = 0;
	bool c = false;
	int[] num = new int[6];
	int aleatorio = (int)(GlobalRandom.NextDouble * 49 + 1);
	int[] insertar = new int[6];

	for (int s = 0; s < insertar.Length;s++)
	{
		Console.Write("Inserte 6 números comprendido entre 1 y 49 (de uno en uno): ");
		insertar[s] = sc.Next();
	}
	
	for (int j = 0;j < num.Length;j++)
	{
		for (int y = j + 1;y < num.Length;y++)
		{
			if (num[y] < num[j])
			{
				aux = num[j];
				num[j] = num[y];
				num[y] = aux;
			}
		}

	} 
	{
	comprobaciones++;
	
	for (int i = 0;i < num.Length;i++)
	{
		num[i] = (int)(GlobalRandom.NextDouble * 49 + 1);
	} 

/
	for (int h = 0;h < insertar.Length;h++)
	{
		for (int k = 0; k < insertar.Length;k++)
		{
			if (insertar[k] < insertar[h])
			{
			   aux2 = insertar[h];
			   insertar[h] = insertar[k];
			   insertar[k] = aux2;
			}
		}
	}

	for (int x = 0;x < num.Length;x++)
	{
		if (num[x] == insertar[x])
		{
			cont++;
		}
			else
			{
				cont = 0;
			}
	}

	}while (cont != 6);
	{
			Console.WriteLine("¡Has acertado todos los números! Número de comprobaciones: " + comprobaciones);

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
