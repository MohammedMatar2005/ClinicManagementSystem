using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Reflection;

namespace ClinicBusiness
{


    public static class DataTableConverter
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this DataTable dt) where T : new()
        {
            ObservableCollection<T> data = new ObservableCollection<T>();

            if (dt == null || dt.Rows.Count == 0) return data; // ✅ حماية من null

            foreach (DataRow row in dt.Rows)
            {
                T item = new T();
                foreach (DataColumn column in dt.Columns)
                {
                    if (row[column.ColumnName] == DBNull.Value) continue;

                    try // ✅ لو column مش موجود كـ property ما يكسر الكل
                    {
                        SetPropertyValue(item, column.ColumnName, row[column.ColumnName]);
                    }
                    catch { /* تجاهل الخاصية اللي ما لقيت match */ }
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
                // ✅ التعامل مع Nullable types
                Type targetType = Nullable.GetUnderlyingType(finalProp.PropertyType)
                                  ?? finalProp.PropertyType;
                object convertedValue = Convert.ChangeType(value, targetType);
                finalProp.SetValue(current, convertedValue);
            }
        }
    }
}