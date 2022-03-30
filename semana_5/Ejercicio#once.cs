
using System;

namespace ejercicio11 {
	class detarea {

		static void Main(string[] args) {
			int c,f,n,x;


			Console.WriteLine("ingresa+el+numero+de+choferes");
			n = int.Parse(Console.ReadLine());
			string[] nombre = new string[n];
			int[] total = new int[n];
			int[,] matriz = new int[n,6];
			for (x=1;x<=n;x++) {
				total[x-1] = 0;
				nombre[x-1] = ();
			}
			for (f=1;f<=n;f++) {
				Console.WriteLine("ingresa+el+nombre[-1]");
				nombre[f-1] = Console.ReadLine();
				for (c=1;c<=6;c++) {
					Console.WriteLine("ingresa+los+kilometros+del+dia+");
					matriz[f-1,c-1] = int.Parse(Console.ReadLine());
					total[f-1] = total[f-1]+matriz[f-1,c-1];
				}
			}
			for (x=1;x<=n;x++) {
				Console.WriteLine(nombre[x-1]+recorrio+total[x-1]+kilometros);
			}
		}

	}

}

