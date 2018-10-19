#region References
using System;
using System.Linq;
#endregion

#region Namespace
namespace Cart.Common
{
    public class SixDigitValueGenarate
    {
        /// <summary>
        /// Randoms the authentication code genarator.
        /// </summary>
        /// <returns></returns>
        public static int randomAuthCodeGenarator()
        {
            Random RndNum = new Random();
            int RnNums = RndNum.Next(100000, 999999);
            return RnNums;
        }

        /// <summary>
        /// Randoms the password genarator.
        /// </summary>
        /// <returns></returns>
        public static string randomPasswordGenarator()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 6)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }
    }
}
#endregion
