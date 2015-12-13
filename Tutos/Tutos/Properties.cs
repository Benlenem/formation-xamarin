using System;

namespace Tutos
{
	public class Properties
	{
		class Person {
			public string Name {    // property with generated getter and setter
				get; set;
			}
		} 

		class Person2 {
			private string name;  // field
			public string Name { // read-only property 
				get{ return name ?? "Inconnu"; }
			}

			public Person2(string name = null){
				this.name = name;
			}
		}

		public Properties ()
		{
			var p = new Person () { Name="Thibaut" };
			Console.WriteLine (p.Name);

			var p2 = new Person2 (null);
			Console.WriteLine (p2.Name);
		}
	}
}

