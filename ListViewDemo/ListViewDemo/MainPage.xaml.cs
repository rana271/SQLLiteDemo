using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            if (Application.Current.Properties.ContainsKey("Uname"))
            {
                lbl1.Text = Application.Current.Properties["Uname"].ToString();
            }

        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            //var response=await DisplayAlert("Confirm", "Are you want to save the doc", "Yes", "No");
            //if(response)
            //{
            //    await DisplayAlert("Success", "Your response is captured", "Ok");
            //}
            var response = await DisplayActionSheet("Hello", "Hello world", "Delete", "Email", "Message");
            
            if(response != null)
            {
                
                await DisplayAlert("Success", response,"Ok");

            }
        }
    }
}
