using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Syncfusion.XForms.DataForm;

namespace Scheduler.Model
{
    public class Meeting : INotifyPropertyChanged
    {
        private string _subject;
        private string _location;
        private DateTime _startTime;
        private DateTime _endTime;
        private string _color = "#7BC667";

        public string Subject
        {
            get => _subject;
            set
            {
                if (value == _subject) return;
                _subject = value;
                switch (_subject)
                {
                    case "General Meeting":
                        Color = "#7BC667";
                        break;
                    case "Release Retrospective":
                        Color = "#9466F2";
                        break;
                    case "Sprint Meeting":
                        Color = "#37AA97";
                        break;
                    default:
                        Color = "#4C3AB9";
                        break;                        
                }
                OnPropertyChanged();
            }
        }

        public string Location
        {
            get => _location;
            set
            {
                if (value == _location) return;
                _location = value;
                OnPropertyChanged();
            }
        }

        public string Color
        {
            get => _color;
            set
            {
                if (value == _color) return;
                _color = value;
                OnPropertyChanged();
            }
        }

        #region DataFormSource
        private DateTime _date;
        [DataType(DataType.Date), Display(Name = "Date")]
        public DateTime Date
        {
            get => _date;
            set
            {
                if (value.Equals(_date)) return;

                _date = value;
                StartTime = new DateTime(_date.Year, _date.Month, _date.Day,
                    StartTime.Hour, StartTime.Minute, StartTime.Second);
            }
        }

        private DateTime _inputStartTime;
        [DataType(DataType.Time), Display(Name = "Start Time")]
        public DateTime InputStartTime
        {
            get => _inputStartTime;
            set
            {
                if (value.Equals(_inputStartTime)) return;

                _inputStartTime = value;
                StartTime = new DateTime(StartTime.Year, StartTime.Month, StartTime.Day, _inputStartTime.Hour,
                    _inputStartTime.Minute, _inputStartTime.Second);
            }
        }

        private DateTime _inputEndTime;
        [DataType(DataType.Time), Display(Name = "End Time")]
        public DateTime InputEndTime
        {
            get => _inputEndTime;
            set
            {
                if (value.Equals(_inputEndTime)) return;

                _inputEndTime = value;
                EndTime = new DateTime(EndTime.Year, EndTime.Month, EndTime.Day, _inputEndTime.Hour,
                    _inputEndTime.Minute, _inputEndTime.Second);
            }
        }
#endregion

        [Display(AutoGenerateField = false)]
        public DateTime StartTime
        {
            get => _startTime;
            set
            {
                if (value.Equals(_startTime)) return;
                _startTime = value;
                EndTime = new DateTime(StartTime.Year, StartTime.Month, StartTime.Day, StartTime.Hour + 1, StartTime.Minute,
                    StartTime
                        .Second);
                OnPropertyChanged();
            }
        }

        [Display(AutoGenerateField = false)]
        public DateTime EndTime
        {
            get => _endTime;
            set
            {
                if (value.Equals(_endTime)) return;
                _endTime = value;
                OnPropertyChanged();
            }
        }

        public Meeting(string subject, string location, DateTime startTime)
        {
            Subject = subject;
            Location = location;
            StartTime = startTime;
            EndTime = new DateTime(StartTime.Year, StartTime.Month, StartTime.Day, StartTime.Hour + 1, StartTime.Minute,
                StartTime
                    .Second);
        }

        public Meeting()
        {
            Date = DateTime.Now;
            InputStartTime = DateTime.Now;
            InputEndTime = DateTime.Now;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
