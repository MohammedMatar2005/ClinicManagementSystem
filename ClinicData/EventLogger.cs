using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClinicDataAccess
{
    public static class EventLogger
    {
        public static void Log(
            string message,
            EventLogEntryType type,
            DateTime? errorDateTime = null,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string filePath = "",
            [CallerLineNumber] int lineNumber = 0)
        {
            string sourceName = "Clinic_Application";
            string logName = "Application";
            DateTime logTime = errorDateTime ?? DateTime.Now;

            try
            {
                // التحقق من وجود المصدر وإنشاؤه إذا لزم الأمر
                if (!EventLog.SourceExists(sourceName))
                {
                    // ملاحظة: تتطلب هذه الخطوة صلاحيات مسؤول (Admin) لمرة واحدة فقط
                    EventLog.CreateEventSource(sourceName, logName);
                }

                string logMessage = $"[{logTime}] Context: {memberName} \nFile: {filePath} \nLine: {lineNumber} \nMessage: {message}";

                EventLog.WriteEntry(sourceName, logMessage, type);
            }
            catch (System.Security.SecurityException)
            {
                // في حال فشل التطبيق في إنشاء المصدر بسبب الصلاحيات
                // يمكنك هنا توجيه اللوج لمكان آخر مؤقتاً أو تنبيه المستخدم
                Debug.WriteLine("برجاء تشغيل التطبيق كمسؤول لإنشاء الـ Event Source.");
            }
        }
    }
}
