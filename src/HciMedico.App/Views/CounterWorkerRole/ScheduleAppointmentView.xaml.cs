using System.Windows;

namespace HciMedico.App.Views.CounterWorkerRole;

public partial class ScheduleAppointmentView : Window
{
    public ScheduleAppointmentView()
    {
        InitializeComponent();

        // Dirty fix due to binding issues
        AppointmentDate.BlackoutDates.Add(new System.Windows.Controls.CalendarDateRange(DateTime.MinValue, DateTime.Today.AddDays(-1)));
    }
}
