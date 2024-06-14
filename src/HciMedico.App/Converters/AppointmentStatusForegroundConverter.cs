using HciMedico.Domain.Models.DisplayModels;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using HciMedico.Domain.Models.Enums;

namespace HciMedico.App.Converters;

public class AppointmentStatusForegroundConverter : IValueConverter
{
    public object? Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is null || value is not AppointmentDisplayModel)
            return null;

        var appointment = value as AppointmentDisplayModel;

        if (appointment!.Status == AppointmentStatus.Cancelled)
            return Brushes.Red;

        if (appointment!.Status == AppointmentStatus.Resolved)
            return Brushes.Green;

        return Brushes.Black;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
        throw new NotImplementedException();
}
