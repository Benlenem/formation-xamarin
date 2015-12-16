using System;

using Xamarin.Forms;

namespace Pages
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
//			MainPage = new ContentPage {
//				Content = new StackLayout {
//					VerticalOptions = LayoutOptions.Center,
//					Children = {
//						new Label {
//							XAlign = TextAlignment.Center,
//							Text = "Welcome to Xamarin Forms!"
//						}
//					}
//				}
//			};

//			MainPage = new Content ();

//			MainPage = new MasterDetail ();

//			var navigationpage = new NavigationPage (new Content ());
//			navigationpage.PushAsync (new Content ());
//
//			MainPage = navigationpage;

			//MainPage = new Tabbed ();

//			MainPage = new TabbedPage(){
//				Children = {
//					new ContentPage { Title="Page1"},
//					new ContentPage { Title="Page2"},
//				}
//			};

//			MainPage = new CarouselPage(){
//				Children = {
//					new ContentPage { Title="Page1", Content = new Label { Text="1"}},
//					new ContentPage { Title="Page2", Content = new Label { Text="2"}},
//					new ContentPage { Title="Page2", Content = new Label { Text="3"}}
//				}
//			};
//
//			MainPage = new Layouts ();
			MainPage = new CircleArea();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

