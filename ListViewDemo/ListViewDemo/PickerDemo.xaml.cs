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
    public partial class PickerDemo : ContentPage
    {
        public PickerDemo()
        {
            InitializeComponent();
        }

        private void contactName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var c=contactName.Items[contactName.SelectedIndex];
            DisplayAlert("Selection", c, "Ok");
        }
    }
}