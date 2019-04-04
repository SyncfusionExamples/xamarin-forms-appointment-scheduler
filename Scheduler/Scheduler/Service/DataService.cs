using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Scheduler.Model;

namespace Scheduler.Service
{
    public class DataService
    {
        public ObservableCollection<Meeting> Data { get; set; }

        private static DataService dataService;

        public static DataService Instance => dataService ?? (dataService = new DataService());

        private DataService()
        {
            Data = new ObservableCollection<Meeting>
            {
                new Meeting("General Meeting", "Online", new DateTime(2019, 4, 1, 10, 0, 0)),
                new Meeting("Release Retrospective", "Office", new DateTime(2019, 4, 6, 9, 0, 0)),
                new Meeting("Sprint Meeting", "Online", new DateTime(2019, 4, 3, 10, 0, 0)),
                new Meeting("Release Planning", "Online", new DateTime(2019, 4, 10, 16, 0, 0)),
                new Meeting("General Meeting", "Office", new DateTime(2019, 4, 25, 11, 0, 0)),
                new Meeting("Customer Meeting", "Online", new DateTime(2019, 5, 3, 12, 0, 0)),
                new Meeting("Sprint Meeting", "Office", new DateTime(2019, 5, 6, 15, 0, 0)),
                new Meeting("Sprint Meeting", "Online", new DateTime(2019, 5, 21, 13, 0, 0)),
                new Meeting("General Meeting", "Office", new DateTime(2019, 6, 8, 16, 0, 0)),
                new Meeting("General Meeting", "Online", new DateTime(2019, 6, 29, 11, 0, 0))
            };

        }
    }
}