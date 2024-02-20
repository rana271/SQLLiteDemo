using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SQlLiteDemo();
            //MainPage = new NavigationPage(new ContactPage());
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
