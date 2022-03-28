// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class detarea {

		static void Main(string[] args) {
			int c;
			string choferes;
			string de;
			string del;
			string dia;
			string el;
			int f;
			string ingresa;
			string kilometros;
			string los;
			int n;
			string numero;
			string recorrio;
			int x;
			Console.WriteLine(ingresa+el+numero+de+choferes);
			n = int.Parse(Console.ReadLine());
			string[] nombre = new string[n];
			int[] total = new int[n];
			int[,] matriz = new int[n,6];
			for (x=1;x<=n;x++) {
				total[x-1] = 0;
				nombre[x-1] = ();
			}
			for (f=1;f<=n;f++) {
				Console.WriteLine(ingresa+el+nombre[-1]);
				nombre[f-1] = Console.ReadLine();
				for (c=1;c<=6;c++) {
					Console.WriteLine(ingresa+los+kilometros+del+dia+c);
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

