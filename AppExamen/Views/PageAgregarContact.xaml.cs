using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppExamen.Models;
using Xamarin.Essentials;
using AppExamen.Controllers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Media;
using System.IO;
using System.Threading;

namespace AppExamen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageAgregarContact : ContentPage
    {
        public PageAgregarContact()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            CancellationTokenSource cts;

            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();

                if (location != null)
                {
                    Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                    latitud.Text = Convert.ToString(location.Latitude);
                    longitud.Text = Convert.ToString(location.Longitude);
                }
                else
                {
                    var request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
                    cts = new CancellationTokenSource();
                    location = await Geolocation.GetLocationAsync(request, cts.Token);

                    if (location != null)
                    {
                        latitud.Text = Convert.ToString(location.Latitude);
                        longitud.Text = Convert.ToString(location.Longitude);
                    }
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                fnsEx.ToString();
                // Handle not supported on device exception
            }
        }

        private void btnagregar_Clicked(object sender, EventArgs e)
        {
            var Contactos = new Contactos()
            {
                nombres = nombre.Text,
                apellidos=apellido.Text,
                edad= Convert.ToInt16(edad.Text),
                pais=pais.SelectedItem.ToString(),
                nota= nota.Text,
                latitud=Convert.ToDouble(latitud.Text),
                longitud=Convert.ToDouble(longitud.Text),
            };

            DataBase.AddContacto(Contactos);

        }
    }
}