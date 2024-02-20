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
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
            list1.ItemsSource = new List<Contact> {
                new Contact { Name = "abc", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                new Contact { Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey, let's talk!" }
            };

        }

        async private void list1_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
            var contact = list1.SelectedItem as Contact;

            await Navigation.PushAsync(new DetailsPage(contact));
            //list1.SelectedItem = null;
        }
    }
}