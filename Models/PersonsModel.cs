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

        // خاصية إضافية للعرض (ReadOnly)
        public string FullName => $"{FirstName} {SecondName} {ThirdName} {LastName}".Replace("  ", " ").Trim();

        // البيانات الشخصية
        public DateTime DateOfBirth { get; set; }

        // التعديل هنا: استخدام bool بدلاً من byte
        public bool Gender { get; set; } // true: Male, false: Female 

        // خاصية عرض الجنس كنص بناءً على القيمة البولينية
        public string GenderText => Gender ? "Male" : "Female";

        // بيانات التواصل
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public string NationalNumber { get; set; }

        // الوسائط
        public string ImagePath { get; set; }
    }
}