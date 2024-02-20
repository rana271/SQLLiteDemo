using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
   
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(Contact contact)
        {
            if(contact == null)
            {
                throw new ArgumentNullException();
            }
            BindingContext = contact;
            InitializeComponent();
            
        }
    }
}