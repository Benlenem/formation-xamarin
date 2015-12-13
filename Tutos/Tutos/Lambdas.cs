using System;
using System.Linq;

namespace Tutos
{
	public class Lambdas
	{
		public Lambdas ()
		{
			Func<string, int> GetLength = (s => s.Length);
			var i = GetLength ("helloworld"); 

			int[] nombres = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
			int pairs = nombres.Count(n => n % 2 == 0);  // nombre d'éléments pairs dans la liste
			double moyenne = nombres.Average (n => n); // Retourne la moyenne des nombres de la liste

		}
	}
}
 
