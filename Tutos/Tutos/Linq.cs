using System;
using System.Linq;
using System.Collections.Generic;

namespace Tutos
{
	public class Linq
	{
		public class Customer
		{
			public string City { get; set; }
			public string FirstName { get; set; }
			public string LastName { get; set; }
		}

		public Linq ()
		{
			var customers = new Customer[]{ 
				new Customer() { City = "Brest", FirstName="Jean", LastName="Durand"},
				new Customer() { City = "Paris", FirstName="Robert", LastName="Durand"},
				new Customer() { City = "Biarritz", FirstName="Michel", LastName="Dupont"}};

			IEnumerable<string> result = from c in customers
					where c.City.StartsWith("B")
				orderby c.LastName
				select c.FirstName;

			IEnumerable<string> result2 = customers.Where( c => c.City.StartsWith("B") )
				.OrderBy( c => c.LastName  )
				.Select( c => c.FirstName );
		}
	}
}

