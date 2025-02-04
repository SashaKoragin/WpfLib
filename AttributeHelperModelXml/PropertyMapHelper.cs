﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;


namespace AttributeHelperModelXml
{
    public static class PropertyMapHelper
    {
        public static void Map(Type type, DataRow row, PropertyInfo prop, object entity)
        {
            List<string> columnNames = AttributeHelper.GetDataNames(type, prop.Name);
            foreach (var columnName in columnNames)
            {
                if (!String.IsNullOrWhiteSpace(columnName) && row.Table.Columns.Contains
                (columnName))
                {
                    var propertyValue = row[columnName];

                    if (propertyValue != DBNull.Value)
                    {
                        if (columnName == "ИНН")
                        {
                            if (propertyValue.ToString().Length == 11)
                            {
                                propertyValue = "0" + propertyValue.ToString();
                            }
                        }
                        ParsePrimitive(prop, entity, propertyValue);
                        break;
                    }
                }
            }
        }
        private static void ParsePrimitive(PropertyInfo prop, object entity, object value)
        {
            if (prop.PropertyType == typeof(string))
            {
                prop.SetValue(entity, value.ToString().Trim(), null);
            }
            else if (prop.PropertyType == typeof(bool) || prop.PropertyType == typeof(bool?))
            {
                if (value == null)
                {
                    prop.SetValue(entity, null, null);
                }
                else
                {
                    prop.SetValue(entity, ParseBoolean(value.ToString()), null);
                }
            }
            else if (prop.PropertyType == typeof(long))
            {
                prop.SetValue(entity, long.Parse(value.ToString()), null);
            }
            else if (prop.PropertyType == typeof(Nullable<long>)){
                if (string.IsNullOrWhiteSpace(value.ToString()))
                {
                    prop.SetValue(entity, null, null);
                }
                else
                {
                    prop.SetValue(entity, long.Parse(value.ToString()), null);
                }
            }
            else if (prop.PropertyType == typeof(int) || prop.PropertyType == typeof(int
            ?))
            {
                if (string.IsNullOrEmpty(value.ToString()))
                {
                    prop.SetValue(entity, 0, null);
                }
                else
                {
                    prop.SetValue(entity, int.Parse(value.ToString()), null);
                }
            }
            else if (prop.PropertyType == typeof(decimal))
            {
                decimal number;
                bool isValid = decimal.TryParse(value.ToString(), out number);
                if (isValid)
                {
                    prop.SetValue(entity, number, null);
                }
            }
            else if (prop.PropertyType == typeof(double) || prop.PropertyType == typeof(
            double?))
            {
                value = Regex.Replace(value.ToString(), @"\s+", "");
                prop.SetValue(entity, GetDouble(value.ToString(), 0.00));
            }
            else if (prop.PropertyType == typeof(DateTime) || prop.PropertyType ==
            typeof(Nullable<DateTime>))
            {
                DateTime date;
                bool isValid = DateTime.TryParse(value.ToString(), out date);
                if (isValid)
                {
                    //Минимальная дата проставлять 
                    prop.SetValue(entity, date, null);
                }
                else
                {
                    isValid = DateTime.TryParseExact(value.ToString(), "MMddyyyy", new
                    CultureInfo("en-US"), DateTimeStyles.AssumeLocal, out date);
                    if (isValid)
                    {
                        prop.SetValue(entity, date, null);
                    }
                }
            }
            else if (prop.PropertyType == typeof(Guid))
            {
                Guid guid;
                bool isValid = Guid.TryParse(value.ToString(), out guid);
                if (isValid)
                {
                    prop.SetValue(entity, guid, null);
                }
                else
                {
                    isValid = Guid.TryParseExact(value.ToString(), "B", out guid);
                    if (isValid)
                    {
                        prop.SetValue(entity, guid, null);
                    }
                }
            }
        }

        public static double GetDouble(string value, double defaultValue)
        {
            double result;

            // Try parsing in the current culture
            if (!double.TryParse(value, System.Globalization.NumberStyles.Any,
        CultureInfo.CurrentCulture, out result) &&
                // Then try in US english
                !double.TryParse(value, System.Globalization.NumberStyles.Any,
        CultureInfo.GetCultureInfo("en-US"), out result) &&
                // Then in neutral language
                !double.TryParse(value, System.Globalization.NumberStyles.Any,
        CultureInfo.InvariantCulture, out result))
            {
                result = defaultValue;
            }
            return result;
        }


        public static bool ParseBoolean(object value)
        {
            if (value == null || value == DBNull.Value) return false;
            switch (value.ToString().ToLowerInvariant())
            {
                case "1":
                case "y":
                case "yes":
                case "true":
                    return true;
                case "0":
                case "n":
                case "no":
                case "false":
                default:
                    return false;
            }
        }
    }
}
