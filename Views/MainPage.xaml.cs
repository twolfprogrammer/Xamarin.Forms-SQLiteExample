using Xamarin.Forms;

namespace SQLiteExample {
	public partial class MainPage : ContentPage {
		public MainPage() {
			BindingContext = new MainPageViewModel();
			InitializeComponent();
		}
	}
}

