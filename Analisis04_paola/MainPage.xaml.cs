namespace Analisis04_paola
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CalcularSueldo(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(HorasEntry.Text) || string.IsNullOrEmpty(PagoHoraEntry.Text))
            {
                ResultadoLabel.Text = "Favor de llenar ambos campos";
                return;
            }

            double horas = double.Parse(HorasEntry.Text);
            double pagoHora = double.Parse(PagoHoraEntry.Text);
            double sueldo = horas * pagoHora;

            ResultadoLabel.Text = "Sueldo semanal: $" + sueldo.ToString("0.00");
        }
    }
}
