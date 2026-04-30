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

            foreach (DataRow row in dt.Rows)
            {
                T item = new T();
                foreach (DataColumn column in dt.Columns)
                {
                    if (row[column.ColumnName] == DBNull.Value) continue;

                    // هذه الدالة ستقوم بالبحث عن الخاصية حتى لو كانت متداخلة بنقطة
                    SetPropertyValue(item, column.ColumnName, row[column.ColumnName]);
                    
                }
                data.Add(item);
            }
            return data;
        }

        private static void SetPropertyValue(object obj, string propertyName, object value)
        {
            // تقسيم المسار إذا كان يحتوي على نقطة (مثل UserInfo.PersonInfo.FullName)
            string[] bits = propertyName.Split('.');
            object current = obj;

            for (int i = 0; i < bits.Length - 1; i++)
            {
                PropertyInfo propertyToGet = current.GetType().GetProperty(bits[i]);
                if (propertyToGet == null) return; // الخاصية غير موجودة

                object next = propertyToGet.GetValue(current);

                // إذا كان الكائن الداخلي null، نقوم بإنشائه (مثلاً إنشاء كائن UserInfo)
                if (next == null)
                {
                    next = Activator.CreateInstance(propertyToGet.PropertyType);
                    propertyToGet.SetValue(current, next);
                }
                current = next;
            }

            // الوصول للخاصية الأخيرة ووضع القيمة فيها
            PropertyInfo finalProp = current.GetType().GetProperty(bits[bits.Length - 1]);
            if (finalProp != null && finalProp.CanWrite)
            {
                // تحويل النوع ليتوافق مع الداتابيز (مثلاً من decimal لـ double أو string)
                object convertedValue = Convert.ChangeType(value, finalProp.PropertyType);
                finalProp.SetValue(current, convertedValue);
            }
        }
    }
}