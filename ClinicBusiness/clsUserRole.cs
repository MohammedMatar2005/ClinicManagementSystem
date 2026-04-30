
using System;
using System.Collections.ObjectModel;
using System.Data;

namespace ClinicBusiness
{
    public class clsUserRole
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }


        // 1. Default Constructor (Add New Mode)
        public clsUserRole()
        {
            this.RoleId = -1;
            this.RoleName = "";
            this.Description = "";
            this.CreatedDate = DateTime.Now;
            Mode = enMode.AddNew;
        }

        // 2. Private Constructor (Update Mode - Used by Find)
        private clsUserRole(int RoleId, string RoleName, string Description, DateTime CreatedDate)
        {
            this.RoleId = RoleId;
            this.RoleName = RoleName;
            this.Description = Description;
            this.CreatedDate = CreatedDate;

            Mode = enMode.Update;
        }

        // 3. Find Method (Business Logic handles the data retrieval via DAL)
        public static clsUserRole Find(int RoleId)
        {
            string RoleName = "";
            string Description = "";
            DateTime CreatedDate = DateTime.Now;


            // استدعاء الـ DAL التي تستخدم SP_UserRoles_GetByID
            bool isFound = clsUserRolesData.GetUserRoleInfoByID(RoleId, ref RoleName, ref Description, ref CreatedDate);

            if (isFound)
                return new clsUserRole(RoleId, RoleName, Description, CreatedDate);
            else
                return null;
        }

        // 4. Save Method (The core Business Logic decision)
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUserRole())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateUserRole();
            }
            return false;
        }

        // 5. Private CRUD helpers that talk to the DAL Stored Procedures
        private bool _AddNewUserRole()
        {
            // استدعاء الـ DAL التي تستخدم SP_UserRoles_Add
            this.RoleId = clsUserRolesData.AddNewUserRole(this.RoleName, this.Description, this.CreatedDate);
            return (this.RoleId != -1);
        }

        private bool _UpdateUserRole()
        {
            // استدعاء الـ DAL التي تستخدم SP_UserRoles_Update
            return clsUserRolesData.UpdateUserRole(this.RoleId, this.RoleName, this.Description, this.CreatedDate);
        }

        // 6. Static Methods for list operations
        public static ObservableCollection<clsUserRole> GetAllUserRoles()
        {
            return clsUserRolesData.GetAllUserRoles().ToObservableCollection<clsUserRole>();
        }

        public static bool Delete(int RoleId)
        {
            return clsUserRolesData.DeleteUserRole(RoleId);
        }

        public static bool IsExist(int RoleId)
        {
            return clsUserRolesData.IsUserRoleExist(RoleId);
        }
    }
}