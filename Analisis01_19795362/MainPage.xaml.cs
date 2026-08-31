using System.Collections.ObjectModel;

namespace Analisis01_19795362
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<int> numerosPares = new ObservableCollection<int>();
        public MainPage()
        {
            InitializeComponent();

            ListaPares.ItemsSource = numerosPares;
        }

        private void BtnGenerar_Clicked(object sender, EventArgs e)
        {
            numerosPares.Clear();

            //del 0 al 100 y agarrp solo con los pares
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    numerosPares.Add(i);
                }
            }
        }
    }
}
