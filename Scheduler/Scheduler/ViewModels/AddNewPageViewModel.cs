using Scheduler.Model;
using Scheduler.Service;
using Xamarin.Forms;

namespace Scheduler.ViewModels
{
    public class AddNewPageViewModel
    {
        public Meeting NewMeeting { get; set; } = new Meeting();

        public Command Submit { get; set; }

        public AddNewPageViewModel()
        {
            var data = DataService.Instance.Data;

            Submit = new Command(() => { data.Add(NewMeeting); });
        }
    }
}
