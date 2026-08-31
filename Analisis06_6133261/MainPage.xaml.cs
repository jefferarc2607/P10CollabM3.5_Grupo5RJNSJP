namespace Analisis06_6133261
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CalcularDolares(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PesosEntry.Text) || string.IsNullOrEmpty(TipoCambioEntry.Text))
            {
                ResultadoLabel.Text = "Favor de llenar ambos campos";
                return;
            }

            double pesos = double.Parse(PesosEntry.Text);
            double tipoCambio = double.Parse(TipoCambioEntry.Text);
            double dolares = pesos / tipoCambio;

            ResultadoLabel.Text = "Pesos: $" + pesos.ToString("0.00") + "\n" +
                                  "Tipo de cambio: $" + tipoCambio.ToString("0.00") + " MXN/USD\n" +
                                  "Dolares: US$" + dolares.ToString("0.00");
        }
    }

}
