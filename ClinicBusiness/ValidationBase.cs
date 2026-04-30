using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace ClinicBusiness
{
    public abstract class ValidationBase : IDataErrorInfo
    {
        // قاموس لتخزين الأخطاء
        public Dictionary<string, string> Errors { get; } = new Dictionary<string, string>();

        // لإرجاع رسالة الخطأ لكل حقل
        public string this[string columnName]
        {
            get
            {
                string error = ValidateProperty(columnName);
                if (error != null) Errors[columnName] = error;
                else Errors.Remove(columnName);

                return error;
            }
        }

        public string Error => null;

        // ميثود سنقوم بعمل Override لها في كل كلاس بزنس
        protected abstract string ValidateProperty(string columnName);

        // ميثود للتأكد إذا كان الكائن كله صالح للحفظ
        public bool IsValid => Errors.Count == 0;
    }
}