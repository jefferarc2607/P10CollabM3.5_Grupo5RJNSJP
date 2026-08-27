namespace Aplicacion3Jhoseline
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MostrarTablas();
        }

        private void MostrarTablas()
        {
            string resultado = "";
            for (int i = 1; i <= 10; i++)
            {
                resultado += "Tabla del " + i + "\n";
                for (int j = 1; j <= 10; j++)
                {
                    int multiplicacion = i * j;
                    resultado += i + " x " + j + " = " + multiplicacion + "\n";
                }
                resultado += "\n";
            }
            ResultadosLabel.Text = resultado;
        }
    }
}
