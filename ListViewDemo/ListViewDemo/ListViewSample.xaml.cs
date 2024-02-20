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
    public partial class ListViewSample : ContentPage
    {
        public ListViewSample()
        {
            InitializeComponent();
            var names = new List<string>
            {
                "abc",
                "xyz",
                "Rana",
                "Ram"

            };
            lst1.ItemsSource = names;
        }
    }
}