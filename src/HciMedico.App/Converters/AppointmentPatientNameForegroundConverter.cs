using HciMedico.Domain.Models.DisplayModels;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace HciMedico.App.Converters;

public class AppointmentPatientNameForegroundConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is AppointmentDisplayModel appointment && !appointment.IsPatientRegistered)
            return Brushes.DarkOrange;

        return Brushes.Black;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
        throw new NotImplementedException();
}
