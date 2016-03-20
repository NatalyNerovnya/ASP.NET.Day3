using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormatProvider
{

    public class Customer : IFormattable
    {
        /// <summary>
        /// Customer class with formating(n,r,p in upper or lower case in any combination)
        /// </summary>

        #region Properties
        public string Name { get; private set; }
        public string ContactPhone { get; private set; }
        public decimal Revenue { get; private set; }

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="phone">Contact phone</param>
        /// <param name="revenue">Revenueparam>
        public Customer(string name, string phone, decimal revenue)
        {
            Name = name;
            ContactPhone = phone;
            Revenue = revenue;
        }

        #endregion

        #region Public Methods
        /// <summary>
        /// Represent customer
        /// </summary>
        /// <param name="format">n,r,p or combinations in any register</param>
        /// <returns>Customer with special format</returns>
        public string ToString(string format)
        {
            return this.ToString(format, new CustomFormatProvider());
        }

        /// <summary>
        /// Represent customer
        /// </summary>
        /// <returns>Name of the customer</returns>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// Represent customer
        /// </summary>
        /// <param name="format">n,r,p or combinations in any register</param>
        /// <param name="formatProvider">IFormatProvider</param>
        /// <returns></returns>
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return String.Format(format, this, (CustomFormatProvider) formatProvider);
        }

        #endregion

        #region Private Methods
        /// <summary>
        /// Return customer with special format
        /// </summary>
        /// <param name="format">n,r,p or combinations in any register</param>
        /// <param name="formatProvider">CustomFormatProvider</param>
        /// <returns>Customer with special format</returns>
        private string ToString(string format, CustomFormatProvider formatProvider)
        {

            if (format == null || formatProvider == null)
                throw new ArgumentNullException();
            return formatProvider.Format(format, this, formatProvider);
        }
#endregion
    }
}
