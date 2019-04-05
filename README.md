# Appointment scheduler in Xamarin.Forms
This app loads the appointments in a calendar and allows you to reschedule the appointments by drag and drop and add new appointments. It also provides four different types of views such as day view, week view, work week view, and month view to manage your schedule in a perfect way.

## Syncfusion Controls

This project uses the following Syncfusion controls:

* [SfSchedule](https://www.syncfusion.com/xamarin-ui-controls/scheduler) - To show the appointments.
* [SfDataForm](https://www.syncfusion.com/xamarin-ui-controls/dataform) - To add a new appointment.

## Screenshots
<img src="Images/xamarin-forms-scheduler-day-view.png"  Width="250"/> <img src="Images/xamarin-forms-scheduler-week-view.png" Width="250" /> <img src="Images/xamarin-forms-scheduler-work-week-view.png" Width="250" />

<img src="Images/xamarin-forms-scheduler-month-view.png" Width="250" /> <img src="Images/xamarin-forms-scheduler-reschedule-appointments.png" Width="250" /> <img src="Images/xamarin-forms-scheduler-add-appointment.png" Width="250" />

## Supported platforms

| Platforms | Supported versions |
| --------- | ------------------ |
| Android   | API level 21 and later versions |
| iOS | iOS 9.0 and later versions |

Refer to the following link for more details: 
[System Requirements](https://help.syncfusion.com/xamarin/installation-and-upgrade/system-requirements)

## Requirements to run demo

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* Xamarin add-ons for Visual Studio (available in Visual Studio installer)

## How to run the sample

1. Clone the sample and open it in Visual Studio.

   *Note: If you download the sample using the "Download ZIP" option, right-click it, select Properties, and then select Unblock.*

2. Register your license key in the App.cs file as demonstrated in the following code.

        public App()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");

            InitializeComponent();

            MainPage = new MasterDetail();
        }

Refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key#xamarinforms) for more details.

3. Set any one of the platform specific projects (iOS, Android) as a start-up project.
4. Clean and build the application.
5. Run the application.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.
