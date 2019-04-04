using Syncfusion.SfSchedule.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scheduler.Views;
using Xamarin.Forms;

namespace Scheduler
{
    public partial class MainPage 
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MenuItem_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AddNewPage(), true);
        }
    }
}
