using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PropDemo : ContentPage
	{
		

      
        public PropDemo()
        {
            InitializeComponent();
           
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["Uname"] = "Admin";
            Navigation.PushAsync(new MainPage());

        }
    }
}