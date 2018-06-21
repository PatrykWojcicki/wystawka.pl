using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace wystawka.pl
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
          
		}
        void OnCall(object sender, EventArgs e) {
            
        }

        private async void GetIt(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ZabierzTo());
        }

        private async void DropIt(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OddajTo());
        }
    }

}
