using System;
using Xamarin.Forms;

namespace SigmaApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnTabelas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TabelasPage());
        }
    }
}
