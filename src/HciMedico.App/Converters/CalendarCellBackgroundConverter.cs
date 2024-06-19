using HciMedico.Domain.Models.DisplayModels;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace HciMedico.App.Converters;

public class CalendarCellBackgroundConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is ScheduleCellDisplayModel cell)
        {
            if (cell.IsToday)
                return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF8692"));

            if (cell.IsSelectedMonth)
                return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#CBD5EB"));

            return Brushes.White;
        }

        return Brushes.White;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
        throw new NotImplementedException();
}
