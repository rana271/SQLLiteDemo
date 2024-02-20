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
	public partial class AfterLoginPage : ContentPage
	{
		public AfterLoginPage ()
		{
			InitializeComponent ();
			if (Application.Current.Properties.ContainsKey("UserName"))
			{
				lbl1.Text = Application.Current.Properties["UserName"].ToString();

            }
		}
	}
}