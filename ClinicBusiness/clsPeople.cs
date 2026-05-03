
using ClinicDataAccess;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;

namespace ClinicBusiness
{
    public class clsPeople : ValidationBase, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        // دالة مساعدة لإرسال الإشعار
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        private int _personId;
        public int PersonId
        {
            get => _personId;
            set { _personId = value; OnPropertyChanged(); }
        }

        private string _firstName;
        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FullName)); // تحديث الاسم الكامل تلقائياً
            }
        }

        private string _secondName;
        public string SecondName
        {
            get => _secondName;
            set
            {
                _secondName = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FullName));
            }
        }

        private string _thirdName;
        public string ThirdName
        {
            get => _thirdName;
            set
            {
                _thirdName = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FullName));
            }
        }

        private string _lastName;
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FullName));
            }
        }

        // هذه الخاصية للقراءة فقط، وتعتمد على الأسماء الأربعة
        public string FullName
        {
            get => $"{FirstName} {SecondName} {ThirdName} {LastName}".Replace("  ", " ").Trim();
        }

        private DateTime _dateOfBirth = DateTime.Now;
        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            set { _dateOfBirth = value; OnPropertyChanged(); }
        }

        private byte _gender;
        public byte Gender
        {
            get => _gender;
            set { _gender = value; OnPropertyChanged(); }
        }

        private string _phone;
        public string Phone
        {
            get => _phone;
            set { _phone = value; OnPropertyChanged(); }
        }

        private string _email;
        public string Email
        {
            get => _email;
            set { _email = value; OnPropertyChanged(); }
        }

        private string _address;
        public string Address
        {
            get => _address;
            set { _address = value; OnPropertyChanged(); }
        }

        private string _imagePath;
        public string ImagePath
        {
            get => _imagePath;
            set { _imagePath = value; OnPropertyChanged(); }
        }

        // 1. Default Constructor (Add New Mode)
        public clsPeople()
        {
            this.PersonId = -1;

            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gender = 1;
            this.Phone = "";
            this.Email = "";
            this.Address = "";
            this.ImagePath = "";



            Mode = enMode.AddNew;
        }

        // 2. Private Constructor (Update Mode - Used by Find)
        private clsPeople(int PersonId, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gender, string Phone, string Email, string Address, string ImagePath)
        {
            this.PersonId = PersonId;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Phone = Phone;
            this.Email = Email;
            this.Address = Address;
            this.ImagePath = ImagePath;


            Mode = enMode.Update;
        }

        // 3. Find Method (Business Logic handles the data retrieval via DAL)
        public static clsPeople Find(int PersonId)
        {
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gender = 0;
            string Phone = "";
            string Email = "";
            string Address = "";
            string ImagePath = "";


            // استدعاء الـ DAL التي تستخدم SP_People_GetByID
            bool isFound = clsPeopleData.GetPeopleInfoByID(PersonId, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gender, ref Phone, ref Email, ref Address, ref ImagePath);

            if (isFound)
                return new clsPeople(PersonId, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Phone, Email, Address, ImagePath);
            else
                return null;
        }

        // 4. Save Method (The core Business Logic decision)
        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPeople())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdatePeople();
            }
            return false;
        }

        // 5. Private CRUD helpers that talk to the DAL Stored Procedures
        private bool _AddNewPeople()
        {
            // استدعاء الـ DAL التي تستخدم SP_People_Add
            this.PersonId = clsPeopleData.AddNewPeople(this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gender, this.Phone, this.Email, this.Address, this.ImagePath);
            return (this.PersonId != -1);
        }

        private bool _UpdatePeople()
        {
            // استدعاء الـ DAL التي تستخدم SP_People_Update
            return clsPeopleData.UpdatePeople(this.PersonId, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gender, this.Phone, this.Email, this.Address, this.ImagePath);
        }

        // 6. Static Methods for list operations
        public static ObservableCollection<clsPeople> GetAllPeople()
        {
            return clsPeopleData.GetAllPeople().ToObservableCollection<clsPeople>();
        }

        public static bool Delete(int PersonId)
        {
            return clsPeopleData.DeletePeople(PersonId);
        }

        public static bool IsExist(int PersonId)
        {
            return clsPeopleData.IsPeopleExist(PersonId);
        }

        protected override string ValidateProperty(string columnName)
        {
            // هنا نضع القواعد (Rules) لكل حقل
            switch (columnName)
            {
                case nameof(FirstName):
                    if (string.IsNullOrWhiteSpace(FirstName)) return "الاسم الأول مطلوب";
                    break;

                case nameof(LastName):
                    if (string.IsNullOrWhiteSpace(LastName)) return "اسم العائلة مطلوب";
                    break;

                case nameof(Phone):
                    if (string.IsNullOrWhiteSpace(Phone)) return "رقم الهاتف مطلوب";
                    if (Phone.Length < 9) return "رقم الهاتف قصير جداً";
                    break;

                case nameof(Email):
                    if (!string.IsNullOrWhiteSpace(Email) && !Email.Contains("@"))
                        return "صيغة البريد الإلكتروني غير صحيحة";
                    break;

                case nameof(DateOfBirth):
                    if (DateOfBirth > DateTime.Now.AddYears(-18))
                        return "يجب أن يكون عمر الطبيب 18 عاماً على الأقل";
                    break;


            }
            return null;
        }

    }




}