using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppExamen.Controllers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//using 
using System.IO;

namespace AppExamen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageContactos : ContentPage
    {
        public PageContactos()
        {
            InitializeComponent();
        }

        private void ToolDeleContacto_Clicked(object sender, EventArgs e)
        {
           // await Navigation.PushAsync(new ());
        }

        private void listacontactos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                Models.Contactos contacto = (Models.Contactos)e.CurrentSelection.FirstOrDefault();
            }
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            listacontactos.ItemsSource = await DataBase.ObtenerListacontatos();
        }

        private void ToolDeleContacto_Clicked_1(object sender, EventArgs e)
        {

        }

        private void listacontactos_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TooDelecontacto_Clicked(object sender, EventArgs e)
        {

        }
    }
}