using PreDemoExam2022App.Common.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace PreDemoExam2022App.Converters
{
    internal class UserRoleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not Role role)
            {
                return null;
            }

            return role.Name switch
            {
                "Admin" => "Админ",
                "User" => "Пользователь",
                _ => role.Name
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
