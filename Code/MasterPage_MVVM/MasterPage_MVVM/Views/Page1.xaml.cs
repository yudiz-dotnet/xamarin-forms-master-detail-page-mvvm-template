using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterPage_MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
            BindingContext = new ViewModels.Page1ViewModel();
		}

        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page4());
            //Application.Current.MainPage = new NavigationPage(new Page4());
        }
    }
}