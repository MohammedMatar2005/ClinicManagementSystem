using System;

namespace WpfApp3.Models
{
    public class UsersModel
    {
        // المعرفات الأساسية
        public int UserId { get; set; }
        public int PersonId { get; set; }

        // بيانات العرض (Display Properties)
        public string FullName { get; set; }    // الاسم الكامل للمستخدم من جدول الأشخاص
        public string RoleName { get; set; }    // اسم الرتبة (Admin, Doctor, Receptionist) بدلاً من الرقم

        // بيانات الحساب
        public string Username { get; set; }

        // ملاحظة: لا نضع كلمة المرور في الموديل المخصص للعرض، 
        // ولكن نتركها فقط إذا كنت تستخدم نفس الموديل للإضافة/التعديل
        public string PasswordHash { get; set; }

        // الحالة والصلاحيات
        public int RoleId { get; set; }
        public bool IsActive { get; set; }

        // التواريخ والتدقيق
        public DateTime CreatedDate { get; set; }
        public DateTime LastLoginDate { get; set; }
    }
}