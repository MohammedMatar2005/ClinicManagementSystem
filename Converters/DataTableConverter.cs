using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Reflection;

namespace ClinicManagementApplication.Converters
{
    public static class DataTableConverter
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this DataTable dt) where T : new()
        {
            ObservableCollection<T> data = new ObservableCollection<T>();
            if (dt == null) return data;

            foreach (DataRow row in dt.Rows)
            {
                T item = new T();
                foreach (DataColumn column in dt.Columns)
                {
                    if (row[column] == DBNull.Value) continue;

                    SetPropertyValue(item, column.ColumnName, row[column]);
                }
                data.Add(item);
            }
            return data;
        }

        private static void SetPropertyValue(object obj, string propertyName, object value)
        {
            string[] bits = propertyName.Split('.');
            object current = obj;

            for (int i = 0; i < bits.Length - 1; i++)
            {
                PropertyInfo propertyToGet = current.GetType().GetProperty(bits[i]);
                if (propertyToGet == null) return;

                object next = propertyToGet.GetValue(current);

                if (next == null)
                {
                    next = Activator.CreateInstance(propertyToGet.PropertyType);
                    propertyToGet.SetValue(current, next);
                }
                current = next;
            }

            PropertyInfo finalProp = current.GetType().GetProperty(bits[bits.Length - 1]);
            if (finalProp != null && finalProp.CanWrite)
            {
                object convertedValue = SafeConvert(value, finalProp.PropertyType);
                finalProp.SetValue(current, convertedValue);
            }
        }

        private static object SafeConvert(object value, Type targetType)
        {
            // التعامل مع الـ Nullable Types (مثل int?)
            Type innerType = Nullable.GetUnderlyingType(targetType) ?? targetType;

            try
            {
                // التعامل مع الـ Enums
                if (innerType.IsEnum)
                {
                    return Enum.ToObject(innerType, value);
                }

                // التحويل العام
                return Convert.ChangeType(value, innerType);
            }
            catch
            {
                return null; // أو إطلاق خطأ مخصص حسب حاجتك
            }
        }
    }
}