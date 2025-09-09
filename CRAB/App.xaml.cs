using CRAB.Vues;

namespace CRAB
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new VuePremierObjet();
        }
    }
}
