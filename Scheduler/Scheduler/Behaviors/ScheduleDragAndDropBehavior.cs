using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Input;
using Scheduler.Model;
using Syncfusion.SfSchedule.XForms;
using Xamarin.Forms;

namespace Scheduler.Behaviors
{
    public class ScheduleDragAndDropBehavior : Behavior<SfSchedule>
    {
        public View AssociatedObject { get; private set; }

        void OnBindingContextChanged(object sender, EventArgs e)
        {
            OnBindingContextChanged();
        }

        protected override void OnAttachedTo(SfSchedule bindable)
        {
            base.OnAttachedTo(bindable);
            AssociatedObject = bindable;
            bindable.BindingContextChanged += OnBindingContextChanged;
            bindable.AppointmentDrop += Bindable_AppointmentDrop;
        }

        private void Bindable_AppointmentDrop(object sender, AppointmentDropEventArgs e)
        {
            (e.Appointment as Meeting).StartTime = e.DropTime;
        }

        protected override void OnDetachingFrom(SfSchedule bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.BindingContextChanged -= OnBindingContextChanged;
            bindable.AppointmentDrop -= Bindable_AppointmentDrop;
            AssociatedObject = null;
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            BindingContext = AssociatedObject.BindingContext;
        }
    }
}