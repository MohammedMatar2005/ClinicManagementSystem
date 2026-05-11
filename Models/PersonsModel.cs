using System;

namespace WpfApp3.Models
{
    public class PersonsModel
    {
        // المعرف الأساسي
        public int PersonId { get; set; }

        // الأسماء المفصلة
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }

        // خاصية إضافية للعرض (ReadOnly) - تسهل الربط في الواجهات جداً
        public string FullName => $"{FirstName} {SecondName} {ThirdName} {LastName}".Replace("  ", " ").Trim();

        // البيانات الشخصية
        public DateTime DateOfBirth { get; set; }
        public byte Gender { get; set; } // 1: Male, 2: Female (أو حسب نظامك)

        // خاصية عرض الجنس كنص
        public string GenderText => Gender == 1 ? "Male" : "Female";

        // بيانات التواصل
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        // الوسائط
        public string ImagePath { get; set; }
    }
}