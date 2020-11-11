using Xamarin.Forms;

namespace MonicaPaez_Examen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new vistaLogin());
            /*Comentario*/
            /*{ BarBackgroundColor = Color.FromRgb(40, 72, 170), BarTextColor = Color.BlueViolet };*/
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
