using HciMedico.Domain.Models.Enums;
using System.Globalization;
using System.Windows.Data;

namespace HciMedico.App.Converters;

public class EnumToBooleanConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not AppointmentStatus || !Enum.IsDefined(value.GetType(), value) || parameter is null)
            return false;

        string? parameterStr = parameter.ToString();

        if (string.IsNullOrEmpty(parameterStr))
            return false;

        return parameterStr.Equals(value.ToString());
    }

    public object? ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is null || parameter is null)
            return null;

        string parameterStr = parameter.ToString();

        if (string.IsNullOrEmpty(parameterStr))
            return null;

        return Enum.Parse(targetType, parameterStr);
    }
}
