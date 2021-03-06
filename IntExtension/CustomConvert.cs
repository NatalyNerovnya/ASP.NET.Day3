﻿using System;
using System.Text;

namespace IntExtension
{
    /// <summary>
    /// Class for converting decimal integer into hexadecimal system
    /// </summary>
    public static class CustomConvert 
    {
        #region Fields

        private enum hexLetters
        {
            A = 10, B, C, D, E, F          
        }

        #endregion

        #region Public Methods
        /// <summary>
        /// Represents integer in hexadecimal system
        /// </summary>
        /// <param name="x">Integer in decimal system</param>
        /// <returns>Hexadecimal representation in format (-)0x######</returns>
        public static string ToHexToString(this int x)
        {
            if (Math.Abs(x) < 16)
                if (x > 0)
                    return ((hexLetters)x).ToString();
                else
                    return "-" + ((hexLetters)Math.Abs(x)).ToString();
            int sign = x / Math.Abs(x);
            if (sign == -1)
                return $"-0x{x.ConvertToHex()}";
            else
                return $"0x{x.ConvertToHex()}";

        }
        #endregion

        #region Private Methods

        /// <summary>
        /// Represents integer in hexadecimal system (without sign "-")
        /// </summary>
        /// <param name="x">Integer in decimal system</param>
        /// <returns>Hexadecimal representation (without sign "-")</returns>
        private static string ConvertToHex(this int x)
        {
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

            char[] hex = new char[numberOfCharacters];
            str.CopyTo(0, hex, 0, numberOfCharacters);
            Array.Reverse(hex);

            return new string(hex);
        }
        #endregion

    }
}
