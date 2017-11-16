using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinYSlim
{
    public partial class MainPage : ContentPage
    {
        RestClient cliente;

        public MainPage()
        {
            InitializeComponent();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            button.Clicked += Button_Clicked;
            cliente = new RestClient();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            texto.Text = await cliente.Get(palabra.Text.ToLower());
            texto.IsVisible = true;
        }
    }
}
