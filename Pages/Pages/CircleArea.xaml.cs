using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Pages
{
	public partial class CircleArea : ContentPage
	{
		public CircleArea ()
		{
			InitializeComponent ();

			BindingContext = new CircleAreaViewModel ();
		}
	}
}

