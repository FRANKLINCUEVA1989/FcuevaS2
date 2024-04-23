namespace FcuevaDS2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            MainPage = new NavigationPage(new Vistas.vGrid()); //navegacion entre distintas ventanas
        }
    }
}
