using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormatProvider
{
    /// <summary>
    /// Class for setting format
    /// </summary>
    public class CustomFormatProvider : IFormatProvider, ICustomFormatter
    {

        public object GetFormat(Type formatType)
        {
            return formatType == typeof(ICustomFormatter) ? this : null;
        }

        private string Format(string format, Customer custom, IFormatProvider formatProvider)
        {
            if (format == null)
                return custom.ToString();
            if (custom == null)
                throw new ArgumentNullException();

            string result = String.Empty;
            format = format.ToUpperInvariant();
           if (format == "N")
                result = $"Customer: {custom.Name.ToString()}.";
            if (format == "R")
                result = $"Revenue: {custom.Revenue.ToString("C")}.";
            if (format == "P")
                result = $"Phone: { custom.ContactPhone.ToString()}.";
            if (format == "NR" || format == "RN")
                result = $"Customer: {custom.Name.ToString()}. \nRevenue: {custom.Revenue.ToString("C")}.";
            if (format == "NP" || format == "PN")
                result = $"Customer: {custom.Name.ToString()}. \nPhone: { custom.ContactPhone.ToString()}.";
            if (format == "NRP" || format == "NPR" || format == "RNP" || format == "RPN" || format ==  "PRN" || format == "PNR")
                result = $"Customer: {custom.Name.ToString()}. \nRevenue: {custom.Revenue.ToString("C")}. \nPhone: { custom.ContactPhone.ToString()}.";
            return result;
        }

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (format == null)
                return arg.ToString();
            if(arg == null)
                throw new ArgumentNullException();
            if(!(arg is Customer))
                throw new ArgumentException();

            return Format(format, (Customer) arg, formatProvider);
        }
        
    }
}
