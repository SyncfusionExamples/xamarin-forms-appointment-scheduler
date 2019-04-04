using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scheduler.Model;
using Syncfusion.SfSchedule.XForms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Scheduler.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddNewPage : ContentPage
	{
        public AddNewPage()
		{
			InitializeComponent ();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(true);
        }
    }
}