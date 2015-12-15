using System;
using System.Collections.Generic;

namespace Tutos
{
	public class Vars
	{
		public Vars ()
		{
			string s = GetString ();

			List<string> list = new List<string>(){ "hey" ,"hoy"};
		}

		public string GetString(){
			return "hello";
		}
	}
}

