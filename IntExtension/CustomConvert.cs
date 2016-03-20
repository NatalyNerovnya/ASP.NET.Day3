using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntExtension
{
    public static class CustomConvert
    {
        private enum hexLetters
        {
            A = 10, B, C, D, E, F          
        }

        public static string ConvertToHex(this int x)
        {
            if (Math.Abs(x) < 16)
                if (x > 0)
                    return ((hexLetters)x).ToString();
                else
                    return "-" + ((hexLetters)Math.Abs(x)).ToString();

            int sign = x / Math.Abs(x);
            x = Math.Abs(x);
            int remainder = 0;
            StringBuilder str = new StringBuilder();
            int numberOfCharacters = 0;
            do
            {
                remainder = x % 16;
                x /= 16;
                if (remainder < 10)
                    str.Append(remainder.ToString());
                else
                    str.Append((hexLetters)remainder);
                numberOfCharacters++;
            } while (x != 0);

            if (sign < 0)
            {
                str.Append("-");
                numberOfCharacters++;
            }
            char[] hex = new char[numberOfCharacters];
            str.CopyTo(0, hex, 0, numberOfCharacters);
            Array.Reverse(hex);


            return new string(hex);
        }

    }
}
