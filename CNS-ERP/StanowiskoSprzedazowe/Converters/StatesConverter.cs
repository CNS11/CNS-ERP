using StanowiskoSprzedazowe.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace StanowiskoSprzedazowe.Converters
{
    public class StatesConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            List<string> Lista = new List<string>();
            List<JednostkaTerytorialna> states = value as List<JednostkaTerytorialna>;
            foreach (var item in states)
            {
                Lista.Add(item.NAZWA);
            }
            return Lista;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class StateConverter : IValueConverter
    {
        static JednostkaTerytorialna lastElem;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string @object;
            JednostkaTerytorialna state = value as JednostkaTerytorialna;
            lastElem = state;
            @object = state.NAZWA;
            return @object;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //return new JednostkaTerytorialna()
            //{
            //    NAZWA = value as string
            ////    };
            JednostkaTerytorialna state = new JednostkaTerytorialna()
            {
                NAZWA = value as string
            };
            
            return state;
           // return value;
        }
    }
    public class DistinctConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ObservableCollection<string> Lista = new ObservableCollection<string>();
            ObservableCollection<JednostkaTerytorialna> states = value as ObservableCollection<JednostkaTerytorialna>;
            foreach (var item in states)
            {
                Lista.Add(item.NAZWA);
            }
            return Lista;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
