#region References
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
#endregion

#region Namespace
namespace Cart.Common
{
    public static class DataFormatHandler
    {
        /// <summary>
        /// Integers the list formater.
        /// </summary>
        /// <param name="dataList">The data list.</param>
        /// <returns></returns>
        public static string IntegerListFormater(this List<int> dataList)
        {
            return string.Join(",", dataList);
        }
        /// <summary>
        /// Strings the list format.
        /// </summary>
        /// <param name="dataList">The data list.</param>
        /// <returns></returns>
        public static string StringListFormat(this List<string> dataList)
        {
            return string.Join("','", dataList);
        }
        /// <summary>
        /// Removes the single quote.
        /// </summary>
        /// <param name="Parameter">The parameter.</param>
        /// <returns></returns>
        public static string RemoveSingleQuote(string Parameter)
        {
            if (string.IsNullOrEmpty(Parameter)) return Parameter;
            return Parameter.Replace("'", "");
        }
        /// <summary>
        /// Replaces the single quote.
        /// </summary>
        /// <param name="Parameter">The parameter.</param>
        /// <returns></returns>
        public static string ReplaceSingleQuote(string Parameter)
        {
            return Parameter.Replace("'", "''");
        }
        /// <summary>
        /// Replaces the zero.
        /// </summary>
        /// <param name="Parameter">The parameter.</param>
        /// <returns></returns>
        public static string ReplaceZero(string Parameter)
        {
            string value = Parameter;
            if (Parameter.Trim() == "")
            {
                value = "0";
            }
            return value;
        }
        /// <summary>
        /// Creates the rand.
        /// </summary>
        /// <returns></returns>
        public static string CreateRand()
        {
            Random rnd = new Random();
            string _tempPass = Convert.ToString(rnd.Next());
            return _tempPass;
        }
        /// <summary>
        /// Gets the last date.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="days">The days.</param>
        /// <returns></returns>
        public static DateTime GetLastDate(DateTime startDate, int days)
        {
            return startDate.AddDays(days);
        }
        /// <summary>
        /// Generics the list to data table.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <returns></returns>
        public static DataTable GenericListToDataTable(object list)
        {
            DataTable dt = null;
            Type listType = list.GetType();
            if (listType.IsGenericType)
            {
                Type elementType = listType.GetGenericArguments()[0];

                //create empty table -- give it a name in case
                //it needs to be serialized
                dt = new DataTable(elementType.Name + "List");

                //define the table -- add a column for each public
                //property or field
                MemberInfo[] miArray = elementType.GetMembers(
                    BindingFlags.Public | BindingFlags.Instance);
                foreach (MemberInfo mi in miArray)
                {
                    if (mi.MemberType == MemberTypes.Property)
                    {
                        PropertyInfo pi = mi as PropertyInfo;

                        //Checking Whether the property is Nullable, and taking the underlying type if yes
                        if (pi.PropertyType.IsGenericType && pi.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                        {
                            dt.Columns.Add(pi.Name, Nullable.GetUnderlyingType(pi.PropertyType));
                        }
                        else
                        {
                            dt.Columns.Add(pi.Name, pi.PropertyType);
                        }
                    }
                    else if (mi.MemberType == MemberTypes.Field)
                    {
                        FieldInfo fi = mi as FieldInfo;
                        dt.Columns.Add(fi.Name, fi.FieldType);
                    }
                }

                //populate the table
                IList il = list as IList;
                foreach (object record in il)
                {
                    int i = 0;
                    object[] fieldValues = new object[dt.Columns.Count];
                    foreach (DataColumn c in dt.Columns)
                    {
                        MemberInfo mi = elementType.GetMember(c.ColumnName)[0];
                        if (mi.MemberType == MemberTypes.Property)
                        {
                            PropertyInfo pi = mi as PropertyInfo;
                            fieldValues[i] = pi.GetValue(record, null);
                        }
                        else if (mi.MemberType == MemberTypes.Field)
                        {
                            FieldInfo fi = mi as FieldInfo;
                            fieldValues[i] = fi.GetValue(record);
                        }
                        i++;
                    }
                    dt.Rows.Add(fieldValues);
                }
            }
            return dt;
        }
        /// <summary>
        /// Manipulates the nullable.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Value">The value.</param>
        /// <returns></returns>
        public static string ManipulateNullable<T>(string Value)
        {
            string _return = string.Empty;
            if (string.IsNullOrEmpty(Value))
                _return = "NULL";
            else
                switch (Type.GetTypeCode(typeof(T)))
                {
                    case TypeCode.DateTime:
                        {
                            _return = "'" + Value + "'";
                            break;
                        }
                    default:
                        {
                            _return = Value;
                            break;
                        }
                }
            return _return;
        }
        /// <summary>
        /// Manipulates the nullable.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Value">The value.</param>
        /// <returns></returns>
        public static string ManipulateNullable<T>(DateTime? Value)
        {
            string _return = string.Empty;
            if (Value == null)
                _return = "NULL";
            else
                switch (Type.GetTypeCode(typeof(T)))
                {
                    case TypeCode.DateTime:
                        {
                            _return = "'" + Value + "'";
                            break;
                        }
                }
            return _return;
        }
    }
}
#endregion