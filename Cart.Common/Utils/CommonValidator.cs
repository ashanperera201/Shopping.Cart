#region References
using System;
using System.Globalization;
using System.Text.RegularExpressions;
#endregion

#region Namespace
namespace Cart.Common
{
    public class CommonValidator
    {
        /// <summary>
        /// Validates the mobile number.
        /// </summary>
        /// <param name="mobileno">The mobileno.</param>
        /// <returns></returns>
        public static bool ValidateMobileNumber(string mobileno)
        {
            bool status = true;
            if (!(Regex.Match(mobileno, @"((07)[0-9]{8})$").Success))
            {
                status = false;
            }
            return status;
        }

        /// <summary>
        /// Validates the ddmmyyyy date.
        /// </summary>
        /// <param name="dob">The dob.</param>
        /// <returns></returns>
        public static bool ValidateDDMMYYYYDate(DateTime dob)
        {
            bool status = true;

            string dateofbirth = dob.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

            if (!(Regex.Match(dateofbirth, @"(^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]((19|20|21)[0-9]{2}))$").Success))
            {
                status = false;
            }
            return status;
        }

        /// <summary>
        /// Adds the prefix to string.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="digitCount">The digit count.</param>
        /// <returns></returns>
        public static string AddPrefixToString(int s, int digitCount)
        {
            return s.ToString().PadLeft(digitCount, '0');
        }

        /// <summary>
        /// Emails the format validator.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public static bool EmailFormatValidator(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);

            if (!match.Success)
            {
                return false;
            }
            return true;
        }
    }
}
#endregion