namespace Analisis02_Navasito
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MostrarCuentaRegresiva();
        }

        private void MostrarCuentaRegresiva()
        {
            string resultado = "";
            for (int i = 10; i >= 1; i--)
            {
                resultado += i + " ";
            }
            ResultadosLabel.Text = resultado;
        }

    }
}
