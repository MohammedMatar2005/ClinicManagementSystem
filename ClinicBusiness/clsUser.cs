
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;

namespace ClinicBusiness
{
    public class clsUser : ValidationBase, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int UserId { get; set; }
        public int PersonId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public int RoleId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastLoginDate { get; set; }

        public clsPeople PersonInfo { get; set; }


        // 1. Default Constructor (Add New Mode)
        public clsUser()
        {
            this.UserId = -1;
            // تعيين القيم الافتراضية هنا

            PersonInfo = new clsPeople();
            Mode = enMode.AddNew;
        }

        // 2. Private Constructor (Update Mode - Used by Find)
        private clsUser(int UserId, int PersonId, string Username, string PasswordHash, int RoleId, bool IsActive, DateTime CreatedDate, DateTime LastLoginDate)
        {
            this.UserId = UserId;
            this.PersonId = PersonId;
            this.Username = Username;
            this.PasswordHash = PasswordHash;
            this.RoleId = RoleId;
            this.IsActive = IsActive;
            this.CreatedDate = CreatedDate;
            this.LastLoginDate = LastLoginDate;
            this.PersonInfo = clsPeople.Find(PersonId);
            Mode = enMode.Update;
        }

        // 3. Find Method (Business Logic handles the data retrieval via DAL)
        public static clsUser Find(int UserId)
        {
            int PersonId = -1;
            string Username = "";
            string PasswordHash = "";
            int RoleId = -1;
            bool IsActive = false;
            DateTime CreatedDate = DateTime.Now;
            DateTime LastLoginDate = DateTime.Now;


            // استدعاء الـ DAL التي تستخدم SP_Users_GetByID
            bool isFound = clsUsersData.GetUserInfoByID(UserId, ref PersonId, ref Username, ref PasswordHash, ref RoleId, ref IsActive, ref CreatedDate, ref LastLoginDate);

            if (isFound)
                return new clsUser(UserId, PersonId, Username, PasswordHash, RoleId, IsActive, CreatedDate, LastLoginDate);
            else
                return null;
        }

        // 4. Save Method (The core Business Logic decision)
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

        // 5. Private CRUD helpers that talk to the DAL Stored Procedures
        private bool _AddNewUser()
        {
            // استدعاء الـ DAL التي تستخدم SP_Users_Add
            this.UserId = clsUsersData.AddNewUser(this.PersonId, this.Username, this.PasswordHash, this.RoleId, this.IsActive, this.CreatedDate, this.LastLoginDate);
            return (this.UserId != -1);
        }

        private bool _UpdateUser()
        {
            // استدعاء الـ DAL التي تستخدم SP_Users_Update
            return clsUsersData.UpdateUser(this.UserId, this.PersonId, this.Username, this.PasswordHash, this.RoleId, this.IsActive, this.CreatedDate, this.LastLoginDate);
        }

        // 6. Static Methods for list operations
        public static ObservableCollection<clsUser> GetAllUsers()
        {
            return clsUsersData.GetAllUsers().ToObservableCollection<clsUser>();
        }

        public static bool Delete(int UserId)
        {
            return clsUsersData.DeleteUser(UserId);
        }

        public static bool IsExist(int UserId)
        {
            return clsUsersData.IsUserExist(UserId);
        }

        public static clsUser Login(string UserName, string PasswordHash)
        {
            int PersonId = -1;
            int UserId = -1;    
            int RoleId = -1;
            bool IsActive = false;
            DateTime CreatedDate = DateTime.Now;
            DateTime LastLoginDate = DateTime.Now;


            // استدعاء الـ DAL التي تستخدم SP_Users_GetByID
            bool isFound = clsUsersData.GetByUsernameAndPassword(UserName, PasswordHash, ref UserId, ref PersonId,  ref RoleId, ref IsActive, ref CreatedDate, ref LastLoginDate);

            if (isFound)
                return new clsUser(UserId, PersonId, UserName, PasswordHash, RoleId, IsActive, CreatedDate, LastLoginDate);
            else
                return null;
        }

        // في clsUser
        protected override string ValidateProperty(string columnName)
        {
            switch (columnName)
            {
                case nameof(Username):
                    if (string.IsNullOrWhiteSpace(Username)) return "اسم المستخدم مطلوب";
                    if (Username.Length < 3) return "اسم المستخدم قصير جداً (3 أحرف على الأقل)";
                    break;

                case nameof(PasswordHash):
                    if (string.IsNullOrWhiteSpace(PasswordHash)) return "كلمة المرور مطلوبة";
                    if (PasswordHash.Length < 6) return "كلمة المرور قصيرة جداً (6 أحرف على الأقل)";
                    break;

                case nameof(RoleId):
                    if (RoleId <= 0) return "يرجى اختيار دور المستخدم";
                    break;
            }
            return null;
        }
    }
}