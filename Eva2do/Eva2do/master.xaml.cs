using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Eva2do
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class master : ContentPage
    {
        public master()
        {
            InitializeComponent();
        }

        private async void bp1_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new P1());
        }

        private async void bp2_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new P2());
        }

        private async void bp3_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new P3());
        }

        private async void bp4_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new P4());
        }
    }
}