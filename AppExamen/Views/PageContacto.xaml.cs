using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppExamen.Controllers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace AppExamen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageContactos : ContentPage
    {
        public PageContactos()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
          base.OnAppearing();

            SeleccionarContactos.ItemsSource = await DataBase.Obtenerlistacontactos();
        }


       

        private  async void ToolDeleInsertar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageAgregarContact());
        }

        private void TooDeleEiminar_Clicked(object sender, EventArgs e)
        {
           
        }

        private  void TooDeleActualizar_Clicked(object sender, EventArgs e)
        {
           
        }
       

        private void SeleccionarContactos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                Models.Contactos contacto = (Models.Contactos)e.CurrentSelection.FirstOrDefault();
            }
        }

        private async void btsalvar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageAgregarContact());
        }

        private void toolsitios_Clicked(object sender, EventArgs e)
        {

        }
    }
}