using System;

namespace MenuAppColab
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void IrAplicacion1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Analisis01_19795362.MainPage());
        }

        private async void IrAplicacion2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Analisis02_Navasito.MainPage());
        }

        private async void IrAplicacion3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Aplicacion3Jhoseline.MainPage());
        }

        private async void IrAplicacion4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Analisis04_paola.MainPage());
        }

        private async void IrAplicacion5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new App5deAvila.MainPage());
        }

        private async void IrAplicacion6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Analisis06_6133261.MainPage());
        }
    }
}