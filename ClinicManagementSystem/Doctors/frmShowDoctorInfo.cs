using ClinicBusiness.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicBusiness.Models;
using ClinicBusiness.DTO.PeopleDTOs;
using ClinicBusiness.DTO.UsersDTOs;
using ClinicBusiness.DTO.DoctorsDTOs;

namespace ClinicManagementSystem
{
    public partial class frmShowDoctorInfo : Form
    {
        private clsDoctor _doctorService;
        private clsUser _userService;
        private clsPeople _peopleService;


        private int _selectedDoctorId;
        public frmShowDoctorInfo(int selectedDoctorId)
        {
            InitializeComponent();
            _selectedDoctorId = selectedDoctorId;

            var _context = new ClinicManagementSystemContext();

            _doctorService = new clsDoctor(_context);
            _userService = new clsUser(_context);
            _peopleService = new clsPeople(_context);
        }

        private PersonViewDTO _personViewDTO;
        private UserDetailsDTO _userDetailsDTO;
        private DoctorEditDTO _doctorViewDTO;

        private async Task<bool> _FillDataInDTOs()
        {
            try
            {
                bool isFound = await _doctorService.IsDoctorExistByIdAsync(_selectedDoctorId);

                if (!isFound)
                {
                    MessageBox.Show("خطأ", "الطبيب غير موجود");
                    return false;
                }

                _doctorViewDTO = await _doctorService.GetDoctorByIdAsync(_selectedDoctorId);

                if (_doctorViewDTO == null) return false;

                int userID = _doctorViewDTO.UserId;

                _userDetailsDTO = await _userService.GetUserByIdAsync(userID);

                int personId = _doctorViewDTO.PersonId;

                _personViewDTO = await _peopleService.GetPersonByIdAsync(personId);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء جلب البيانات من الخادم: {ex.Message}", "خطأ في قاعدة البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void _MappingDataFormDTOsToControls()
        {
            try
            {
                //  Person Fields
                txtNationalNo.Text = _personViewDTO.NationalNumber.ToString();
                txtFullName.Text = _personViewDTO.FullName.ToString();
                txtGender.Text = _personViewDTO.Gender.ToString();
                txtBirthDate.Text = _personViewDTO.DateOfBirth.ToShortDateString();
                txtPhone.Text = _personViewDTO.Phone.ToString();
                txtEmail.Text = _personViewDTO.Email.ToString();
                txtAddress.Text = _personViewDTO.Address.ToString();

                //  User Fields
                txtUserId.Text = _userDetailsDTO.UserId.ToString();
                txtUsername.Text = _userDetailsDTO.Username.ToString();
                txtPermissions.Text = _userDetailsDTO.RoleName.ToString();
                chkIsActive.Checked = _userDetailsDTO.IsActive;

                //  Doctor Fields
                txtDoctorId.Text = _doctorViewDTO.DoctorId.ToString();
                txtSpecialization.Text = _doctorViewDTO.Specialization.ToString();
                txtExperienceYears.Text = _doctorViewDTO.ExperienceYears.ToString();
                txtLicenseNo.Text = _doctorViewDTO.LicenseNumber.ToString();
                txtClinicRoom.Text = _doctorViewDTO.OfficeLocation.ToString();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("تنبيه: بعض حقول البيانات فارغة أو غير مكتملة في النظام.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ غير متوقع أثناء عرض البيانات: {ex.Message}", "خطأ داخلي", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void _LoadDoctorData()
        {
            try
            {
                if (await _FillDataInDTOs())
                {
                    _MappingDataFormDTOsToControls();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"فشل تحميل واجهة الطبيب: {ex.Message}", "خطأ في النظام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void frmShowDoctorInfo_Load(object sender, EventArgs e)
        {
            _LoadDoctorData();
        }
    }
}