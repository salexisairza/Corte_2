using System;

public class Ejercicio_DiscoDurodeRoer_Arrays_3
{

	public static void Main(string[] args)
	{

		//Indicamos el tamaño
		string texto = JOptionPane.showInputDialog("Introduce un tamaño");
		int[] num = new int[int.Parse(texto)];

		//Invocamos las funciones
		rellenarNumPrimosAleatorioArray(num, 1, 100);

		mostrarArray(num);

		//Saco el primo mayor
		int primoMayor = mayor(num);
		Console.WriteLine("El primo más grande es el " + primoMayor);
	}

	public static void rellenarNumPrimosAleatorioArray(int[] lista, int a, int b)
	{

		int i = 0;

		//Usamos mejor un while, ya que solo aumentara cuando genere un primo
		while (i < lista.Length)
		{
			int num = ((int)Math.Floor(GlobalRandom.NextDouble * (a - b) + b));
			if (esPrimo(num))
			{
				lista[i] = num;
				i++;
			}
		}
	}
	private static bool esPrimo(int num)
	{

		//Un numero negativo, el 0 y el 1, son directamente no primos.
		if (num <= 1)
		{
			return false;
		}
		else
		{

			//declaracion       
			int prueba;
			int contador = 0;
			//Hacemos la raiz cuadrada y lo usamos para dividir el numero original
			prueba = (int)Math.Sqrt(num);
			//Bucle que cuenta los numeros divisibles, podemos hacerlo con while
			for (;prueba > 1;prueba--)
			{
				if (num % prueba == 0)
				{
					contador += 1;
				}
			}
			return contador < 1;
		}
	}

	public static void mostrarArray(int[] lista)
	{
		for (int i = 0;i < lista.Length;i++)
		{
			Console.WriteLine("En el indice " + i + " esta el valor " + lista[i]);
		}
	}

	public static int mayor(int[] lista)
	{
		int mayor = 0;
		for (int i = 0;i < lista.Length;i++)
		{
			if (lista[i] > mayor)
			{
				mayor = lista[i];
			}
		}

		return mayor;
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