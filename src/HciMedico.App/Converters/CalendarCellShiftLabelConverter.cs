using HciMedico.Domain.Models.DisplayModels;
using System.Globalization;
using System.Windows.Data;

namespace HciMedico.App.Converters;

public class CalendarCellShiftLabelConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is ScheduleCellDisplayModel cell && !string.IsNullOrEmpty(cell.ShiftStartTime) && !string.IsNullOrEmpty(cell.ShiftEndTime))
        {
            string parameterStringValue = parameter.ToString() ?? string.Empty;

            if (parameterStringValue.Equals("StartTime"))
                return "Start time: ";

            if (parameterStringValue.Equals("EndTime"))
                return "End time: ";
        }

        return string.Empty;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
        throw new NotImplementedException();
}
