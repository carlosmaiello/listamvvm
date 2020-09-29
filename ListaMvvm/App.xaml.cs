using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListaMvvm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new View.ListaItemPage();
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
