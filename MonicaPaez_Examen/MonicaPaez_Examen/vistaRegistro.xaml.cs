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
    public partial class vistaRegistro : ContentPage
    {
        public vistaRegistro( string nombre, string usuario, string cuotas )
        {
            double diferencia = Convert.ToDouble(cuotas)*3;
            InitializeComponent();
            lblUsuario.Text = "Bienvenidos Universidad Israel:" + usuario;
            txtNombre.Text = nombre;
            txtCuotas.Text = cuotas.ToString();
            txtTotal.Text = diferencia.ToString();
        }
    }
}