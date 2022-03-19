using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppExamen.Models;
using AppExamen.Controllers;
using AppExamen.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace AppExamen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePrincipal : ContentPage
    {
        public PagePrincipal()
        {
            InitializeComponent();

        }
       
        private async void btSalvar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageContactos());

            var Cont = new Contactos()
            {
                nombre = nombre.Text,
                telefono=telefono.Text,
                edad = Convert.ToInt16(edad.Text),
                pais = pais.SelectedItem.ToString(),
                nota = nota.Text,


            };

            if (await DataBase.AddContacto(Cont) > 0)
            {

                await DisplayAlert("Alerta", "Debe escribir una nota", "Ok");

            }
            else
            {

                await DisplayAlert("Alerta", "Debe escribir un Telefono", "Ok");

                await DisplayAlert("Alerta", "Debe escribir un nombre", "Ok");
            }

        }

        private async void TooContacto_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageContactos());
        }
    }
}