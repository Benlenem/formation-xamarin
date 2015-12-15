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

			string[] menuEntries = 
			{
				"Menu1", "Menu2", "Menu3"
			};

			// Create ListView for the master page.
			ListView listView = new ListView
			{
				ItemsSource = menuEntries
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

			// Define a selected handler for the ListView.
			listView.ItemSelected += (sender, args) =>
			{
				// Set the BindingContext of the detail page.
				this.Detail.BindingContext = args.SelectedItem;

				// Show the detail page.
				this.IsPresented = false;
			};

			// Initialize the ListView selection.
			listView.SelectedItem = menuEntries[0];
		}
	}
}


