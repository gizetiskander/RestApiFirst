using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RestApiFirst.Views;
using RestApiFirst.Service;

namespace RestApiFirst
{
    public partial class App : Application
    {
        public static EntryManager CountManager { get; private set; }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new EntryPage());
            CountManager = new EntryManager(new RestService());
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
