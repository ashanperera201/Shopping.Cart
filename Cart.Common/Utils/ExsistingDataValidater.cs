#region References
using System.Collections.Generic;
using System.Reflection;
#endregion

#region Namespace
namespace Cart.Common
{
    public static class ExsistingDataValidater
    {
        /// <summary>
        /// Sets the update object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="existingObject">The existing object.</param>
        /// <param name="validationObject">The validation object.</param>
        /// <returns></returns>
        public static T SetUpdateObject<T>(T existingObject, T validationObject)
        {

            IList<PropertyInfo> properties = new List<PropertyInfo>(typeof(T).GetProperties());

            foreach (PropertyInfo property in properties)
            {
                object validationObjectValue = property.GetValue(validationObject, null);

                if ((validationObjectValue != null)
                    && (!string.IsNullOrEmpty(validationObjectValue as string)))
                {
                    property.SetValue(existingObject, validationObjectValue);
                }
            }
            return existingObject;
        }
    }
}
#endregion