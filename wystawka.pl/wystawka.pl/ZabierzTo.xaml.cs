using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace wystawka.pl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ZabierzTo : ContentPage

    {
        public ObservableCollection<string> Items { get; set; }

        public ZabierzTo()
        {
            InitializeComponent();

            
        }
    }
}
