using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MonicaPaez_Examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class vistaLogin : ContentPage
    {
        public vistaLogin()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string user = "estudiante2020";
            string pass = "uisrael2020";
            string usuario = txtUsuario.Text;
            string password = txtPasswd.Text;

            try
            {
                if (user == usuario && pass == password)
                {
                    await Navigation.PushAsync(new MainPage(user, pass));
                }
                else
                {
                    string mensaje = "El Usuario o la contraseña no son validos.";
                    await DisplayAlert("Mensaje de Alerta", mensaje, "Aceptar");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Mensaje de Alerta", ex.Message, "Aceptar");
            }
        }
    }
  }

    