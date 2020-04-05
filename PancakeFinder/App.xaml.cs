using System;
using PancakeFinder.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PancakeFinder
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PancakePage();
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
