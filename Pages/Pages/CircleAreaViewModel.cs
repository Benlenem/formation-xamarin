using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using System.Windows.Input;

namespace Pages
{
	public class CircleAreaViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public CircleAreaViewModel ()
		{
			ClearCommand = new Command (o => {
				Radius = "";
			});
		}
		
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public string Area {
			get {
				string stringifiedArea;
				if (mRadius == 0) {
					stringifiedArea = "N/A";
				} else {
					var area = Math.PI * mRadius * mRadius;
					stringifiedArea = string.Format ("Aire : {0}", area);
				}

				return stringifiedArea;


			}
		}

		public Color ResultColor {
			get {
				return mRadius == 0 ? Color.Red : Color.Green;
			}
		}

		private double mRadius;
		public string Radius {
			get {
				return mRadius.ToString();
			}
			set {
				mRadius = StringToDouble(value);
				OnPropertyChanged ("Radius");
				OnPropertyChanged ("Area");
				OnPropertyChanged ("ResultColor");
			}
		}

		public ICommand ClearCommand {
			get;
			private set;
		}

		private double StringToDouble(string s){
			try {
				var trimmed = s.Trim ().Replace (" ", "");
				return Convert.ToDouble(trimmed);
			}
			catch(Exception e){
				return 0;
			}
		}
	}
}

