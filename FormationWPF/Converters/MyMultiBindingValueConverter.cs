using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace FormationWPF.Converters
{
    public class MyMultiBindingValueConverter : IMultiValueConverter
    {
        /// <summary>
        /// La méthode Convert réçoit un  tableau de chaine de caractère en entrée puis la converti en string 
        /// </summary>
        /// <param name="values"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if(values.Length <= 0)
            {
                return string.Empty;
            }
            string res = string.Empty;
            //[john doe]  ==>  "john    doe"
            foreach (var item in values)
            {
                res += item + "\t";
            }
            return res;
        }

        /// <summary>
        /// La méthode ConvertBack réçoit une chaine de caractère en entrée puis la converti en tableau de chaine de caractère
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetTypes"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            //"john  doe"  => [john doe]
          string str  = value as string;

            if(str == string.Empty)
            {
                return null;
            }

            return str.Split('\t');
        }
    }
}
