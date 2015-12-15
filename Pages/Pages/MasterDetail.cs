using System;

using Xamarin.Forms;

namespace Pages
{
	public class MasterDetail : MasterDetailPage
	{
		public MasterDetail ()
		{
			Label header = new Label
			{
				Text = "MasterDetail",
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.Center
			};

			Color[] colors = 
			{
				Color.Aqua,
				Color.Black,
				Color.Blue,
				Color.Fuchsia,
				Color.Gray,
				Color.Green,
				Color.Lime,
				Color.Maroon,
				Color.Navy,
				Color.Olive,
				Color.Purple,
				Color.Red,
				Color.Silver,
				Color.Teal,
				Color.White,
				Color.Yellow
			};

			// Create ListView for the master page.
			ListView listView = new ListView
			{
				ItemsSource = colors
			};

			// Create the master page with the ListView.
			this.Master = new ContentPage
			{
				Title = header.Text,
				Content = new StackLayout
				{
					Children = 
					{
						header, 
						listView
					}
					}
			};

			// Create the detail page using NamedColorPage and wrap it in a
			// navigation page to provide a NavigationBar and Toggle button
			this.Detail = new NavigationPage(new ContentPage());

			// For Windows Phone, provide a way to get back to the master page.
			if (Device.OS == TargetPlatform.WinPhone)
			{
				(this.Detail as ContentPage).Content.GestureRecognizers.Add(
					new TapGestureRecognizer((view) =>
						{
							this.IsPresented = true;
						}));
			}

			// Define a selected handler for the ListView.
			listView.ItemSelected += (sender, args) =>
			{
				// Set the BindingContext of the detail page.
				this.Detail.BindingContext = args.SelectedItem;

				// Show the detail page.
				this.IsPresented = false;
			};

			// Initialize the ListView selection.
			listView.SelectedItem = colors[0];
		}
	}
}


