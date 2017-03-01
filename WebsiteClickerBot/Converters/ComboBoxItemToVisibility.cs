using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WebsiteClickerBot.Converters
{
    public class ComboBoxItemToVisibility : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (parameter?.ToString())
            {
                case "TextParam":
                    return value?.ToString() == "Type text" ? Visibility.Visible : Visibility.Hidden;
                case "PasswordParam":
                    return value?.ToString() == "Type password" ? Visibility.Visible : Visibility.Hidden;
                case "ClickParam":
                    return value?.ToString() == "Click" ? Visibility.Visible : Visibility.Hidden;
                default:
                    return Visibility.Hidden;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
