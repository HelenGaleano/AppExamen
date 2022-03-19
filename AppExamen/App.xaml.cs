using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppExamen.Controllers;
using System.IO;
using AppExamen.Views;

namespace AppExamen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DB.conexion(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DBPR.db3"));
            
            MainPage = new NavigationPage(new PagePrincipal());
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
