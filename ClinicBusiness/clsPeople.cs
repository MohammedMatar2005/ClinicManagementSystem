using ClinicDataAccess;
using System;
using System.Data;

namespace ClinicBusiness
{
    public class clsPeople
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode { get; set; }

        // =========================
        // Properties
        // =========================
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }

        public string NationalNumber{ get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public string FullName =>
            $"{FirstName} {SecondName} {ThirdName} {LastName}"
            .Replace("  ", " ")
            .Trim();

        // =========================
        // Constructor (AddNew)
        // =========================
        public clsPeople()
        {
            this.PersonId = -1;
            
            this.FirstName = string.Empty;
            this.SecondName = string.Empty;
            this.ThirdName = string.Empty;
            this.LastName = string.Empty;
           
            this.DateOfBirth = DateTime.Now;
            this.Gender = false;
           
            this.Phone = string.Empty;
            this.Email = string.Empty;
            this.Address = string.Empty;
            this.NationalNumber = string.Empty;

            Mode = enMode.AddNew;
        }

        // =========================
        // Constructor (Update)
        // =========================
        private clsPeople(
            int personId,
            string firstName,
            string secondName,
            string thirdName,
            string lastName,
            DateTime dateOfBirth,
            bool gender,
            string phone,
            string email,
            string address,
            string nationalNo)
        {
            this.PersonId = personId;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.LastName = lastName;
            
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            
            this.Phone = phone;
            this.Email = email;
            this.Address = address;
            this.NationalNumber = nationalNo;

            Mode = enMode.Update;
        }

        // =========================
        // Find
        // =========================
        public static clsPeople Find(int personId)
        {
            string firstName = "", secondName = "", thirdName = "", lastName = "";
            DateTime dob = DateTime.Now;
            bool gender = false;
            string phone = "", email = "", address = "", nationalNo = "";

            bool found = clsPeopleData.GetPersonById(
                personId,
                ref firstName,
                ref secondName,
                ref thirdName,
                ref lastName,
                ref dob,
                ref gender,
                ref phone,
                ref email,
                ref address,
                ref nationalNo
            );

            if (!found)
                return null;

            return new clsPeople(
                personId,
                firstName,
                secondName,
                thirdName,
                lastName,
                dob,
                gender,
                phone,
                email,
                address,
                nationalNo
            );
        }

        // =========================
        // Add
        // =========================
        private bool _Add()
        {
            this.PersonId = clsPeopleData.AddNewPerson(
                this.FirstName,
                this.SecondName,
                this.ThirdName,
                this.LastName,
                this.DateOfBirth,
                this.Gender,
                this.Phone,
                this.Email,
                this.Address,
                this.NationalNumber
            );

            return this.PersonId != -1;
        }

        // =========================
        // Update
        // =========================
        private bool _Update()
        {
            return clsPeopleData.UpdatePerson(
                this.PersonId,
                this.FirstName,
                this.SecondName,
                this.ThirdName,
                this.LastName,
                this.DateOfBirth,
                this.Gender,
                this.Phone,
                this.Email,
                this.Address,
                this.NationalNumber
            );
        }

        // =========================
        // Save
        // =========================
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_Add())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _Update();

                default:
                    return false;
            }
        }

        // =========================
        // Delete
        // =========================
        public static bool Delete(int id)
            => clsPeopleData.DeletePerson(id);

        // =========================
        // Get All (DataTable)
        // =========================
        public static DataTable GetAll()
            => clsPeopleData.GetAllPeople();

        // =========================
        // Is Exist
        // =========================
        public static bool IsExist(int personId)
        {
            // تعريف متغيرات مؤقتة فقط لاستقبال البيانات من الدالة
            string firstName = "", secondName = "", thirdName = "", lastName = "";
            string nationalNo = "", email = "", phone = "", address = "";
            DateTime dateOfBirth = DateTime.Now;
            bool gender = false;
            

            // نقوم باستدعاء الدالة وتخزين النتيجة في متغير بولين
            bool isFound = clsPeopleData.GetPersonById(
                personId,
                ref firstName,
                ref secondName,
                ref thirdName,
                ref lastName,
                // تأكد من ترتيب الحقول حسب تعريفها في clsPeopleData
                ref dateOfBirth,
                ref gender,
                ref phone,
                ref email,
                ref address,
                ref nationalNo
            );

            // إذا كانت النتيجة true تعيد الدالة true، وإذا لم تجد الشخص تعيد false
            return isFound;
        }
    }
}