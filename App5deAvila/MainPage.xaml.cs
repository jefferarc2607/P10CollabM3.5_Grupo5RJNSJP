namespace App5deAvila
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CalcularPresupuesto(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PersonasEntry.Text))
            {
                ResultadoLabel.Text = "Favor de ingresar el numero de personas";
                return;
            }

            int personas = int.Parse(PersonasEntry.Text);
            double costoPorPersona;
            string tarifaAplicada;

            if (personas <= 200)
            {
                costoPorPersona = 95.00;
                tarifaAplicada = "$95.00";
            }
            else if (personas <= 300)
            {
                costoPorPersona = 85.00;
                tarifaAplicada = "$85.00";
            }
            else
            {
                costoPorPersona = 75.00;
                tarifaAplicada = "$75.00";
            }

            double total = personas * costoPorPersona;

            ResultadoLabel.Text = "Personas: " + personas + "\n" +
                                  "Tarifa aplicada: " + tarifaAplicada + " por persona\n" +
                                  "Presupuesto total: $" + total.ToString("0.00");
        }
    }
}
