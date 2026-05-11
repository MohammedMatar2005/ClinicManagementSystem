using System;
using System.Data;
using ClinicDataAccess;

namespace ClinicBusiness
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int UserId { get; set; }
        public int PersonId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public int RoleId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastLoginDate { get; set; } // Nullable لأن المستخدم الجديد لم يدخل بعد

        public string FullName { get; }

        // كائن الشخص المرتبط بالمستخدم
        public clsPeople PersonInfo { get; set; }

        // 1. Constructor للـ Add New
        public clsUser()
        {
            this.UserId = -1;
            this.PersonId = -1;
            this.Username = "";
            this.PasswordHash = "";
            this.RoleId = -1;
            this.IsActive = true;
            this.CreatedDate = DateTime.Now;
            this.LastLoginDate = null;
            this.FullName ="";

            Mode = enMode.AddNew;
        }

        // 2. Constructor خاص للـ Update (يستخدم داخلياً عند البحث)
        private clsUser(int UserId, int PersonId, string FullName, string Username, string PasswordHash,
            int RoleId, bool IsActive, DateTime CreatedDate, DateTime? LastLoginDate)
        {
            this.UserId = UserId;
            this.PersonId = PersonId;
            this.FullName = FullName;
            this.Username = Username;
            this.PasswordHash = PasswordHash;
            this.RoleId = RoleId;
            this.IsActive = IsActive;
            this.CreatedDate = CreatedDate;
            this.LastLoginDate = LastLoginDate;

            // جلب معلومات الشخص تلقائياً عند تحميل المستخدم
            this.PersonInfo = clsPeople.Find(PersonId);
            Mode = enMode.Update;
        }

        // 3. دالة Find لجلب مستخدم عن طريق ID
        public static clsUser Find(int UserId)
        {
            int PersonId = -1;
            string Username = "";
            string PasswordHash = "";
            int RoleId = -1;
            bool IsActive = false;
            DateTime CreatedDate = DateTime.Now;
            DateTime? LastLoginDate = null;
            string FullName = "";

            bool isFound = clsUsersData.GetUserById(UserId, ref PersonId, ref FullName, ref Username,
                ref PasswordHash, ref RoleId, ref IsActive, ref CreatedDate, ref LastLoginDate);

            if (isFound)
                return new clsUser(UserId, PersonId, FullName, Username, PasswordHash, RoleId, IsActive, CreatedDate, LastLoginDate);
            else
                return null;
        }

        // 4. دالة Save (تحدد هل سنضيف أم سنعدل)
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }

        private bool _AddNewUser()
        {
            this.UserId = clsUsersData.AddNewUser(this.PersonId, this.Username,
                 this.PasswordHash, this.RoleId, this.IsActive);

            return (this.UserId != -1);
        }

        private bool _UpdateUser()
        {
            return clsUsersData.UpdateUser(this.UserId, this.PersonId, this.Username,
                this.PasswordHash, this.RoleId, this.IsActive, this.LastLoginDate);
        }

        // 5. العمليات الـ Static (DataTable) كما طلبت
        public static DataTable GetAllUsers()
        {
            return clsUsersData.GetAllUsers();
        }

        public static bool Delete(int UserId)
        {
            return clsUsersData.DeleteUser(UserId);
        }

        public static bool IsExistByPersonId(int PersonId)
        {
            return clsUsersData.IsUserExistByPersonId(PersonId);
        }

        // 6. دالة Login (مبسطة وتعتمد على دالة Find لجلب البيانات الكاملة)
        public static clsUser Login(string Username, string PasswordHash)
        {
            int UserId = -1;
            int PersonId = -1;
            int RoleId = -1;
            bool IsActive = false;

            bool isFound = clsUsersData.Login(Username, PasswordHash, ref UserId, ref PersonId, ref RoleId, ref IsActive);

            if (isFound)
                return Find(UserId); // نستخدم Find هنا لملء كل تفاصيل الكائن (CreatedDate, الخ)
            else
                return null;
        }
    }
}