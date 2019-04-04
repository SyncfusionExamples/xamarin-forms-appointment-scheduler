using System;
using System.Collections.Generic;
using System.Text;
using Scheduler.Model;
using Scheduler.Service;
using Xamarin.Forms;

namespace Scheduler.ViewModels
{
    public class ViewModelBase
    {
        public IList<Meeting> Meetings { get; set; }

        public ViewModelBase()
        {
            Meetings = DataService.Instance.Data;
        }
    }
}
