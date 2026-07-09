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
        private readonly clsDoctor _doctorService;
        private readonly int _selectedDoctorId;
        private DoctorSaveDTO _doctorSaveDTO;

        public frmShowDoctorInfo(int selectedDoctorId)
        {
            InitializeComponent();
            _selectedDoctorId = selectedDoctorId;

            // إنشاء الـ Context وحقنه في السيرفس (تمت إزالة السيرفسز غير المستخدمة)
            var context = new ClinicManagementSystemContext();
            _doctorService = new clsDoctor(context);
        }

        private async Task<bool> _FillDataInDTOs()
        {
            try
            {
                // جلب كائن الـ DTO المجمع بالكامل في طلب واحد فقط للخادم
                _doctorSaveDTO = await _doctorService.GetDoctorByIdAsync(_selectedDoctorId);

                // إذا كان الـ DTO فارغاً، فهذا يعني أن الطبيب غير موجود في قاعدة البيانات
                if (_doctorSaveDTO == null)
                {
                    MessageBox.Show(
                        "لم يتم العثور على بيانات هذا الطبيب، قد يكون قد تم حذفه.",
                        "خطأ في البيانات",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"حدث خطأ أثناء جلب البيانات من الخادم:\n{ex.Message}",
                    "خطأ في قاعدة البيانات",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                return false;
            }
        }

        private void _MappingDataFormDTOsToControls()
        {
            try
            {
                // 1. بيانات الشخص (Person Fields)
                txtNationalNo.Text = _doctorSaveDTO.Person.NationalNumber;

                // تجميع الاسم الكامل لأن الهيكل الجديد يحتوي على حقول الاسم منفصلة
                txtFullName.Text = $"{_doctorSaveDTO.Person.FirstName} {_doctorSaveDTO.Person.SecondName} {_doctorSaveDTO.Person.ThirdName} {_doctorSaveDTO.Person.LastName}".Replace("  ", " ").Trim();

                txtGender.Text = _doctorSaveDTO.Person.Gender == true ? "ذكر" : "أنثى";
                txtBirthDate.Text = _doctorSaveDTO.Person.DateOfBirth.ToString("yyyy-MM-dd");
                txtPhone.Text = _doctorSaveDTO.Person.Phone;
                txtEmail.Text = _doctorSaveDTO.Person.Email;
                txtAddress.Text = _doctorSaveDTO.Person.Address;

                // 2. بيانات حساب المستخدم (User Fields)
                txtUserId.Text = _doctorSaveDTO.User.UserId.ToString();
                txtUsername.Text = _doctorSaveDTO.User.Username;
                txtPermissions.Text = "طبيب"; // أو جلب اسم الدور بناءً على الـ RoleId إذا كان متوفراً
                chkIsActive.Checked = _doctorSaveDTO.User.IsActive;

                // 3. البيانات المهنية للطبيب (Doctor Fields)
                txtDoctorId.Text = _doctorSaveDTO.DoctorDetails.DoctorId.ToString();
                txtSpecialization.Text = _doctorSaveDTO.DoctorDetails.Specialization;
                txtExperienceYears.Text = _doctorSaveDTO.DoctorDetails.ExperienceYears.ToString();
                txtLicenseNo.Text = _doctorSaveDTO.DoctorDetails.LicenseNumber;
                txtClinicRoom.Text = _doctorSaveDTO.DoctorDetails.OfficeLocation;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("تنبيه: بعض حقول البيانات فارغة أو غير مكتملة في النظام.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ غير متوقع أثناء عرض البيانات: {ex.Message}", "خطأ داخلي", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
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
                MessageBox.Show($"فشل تحميل واجهة الطبيب: {ex.Message}", "خطأ في النظام", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                this.Close();
            }
        }

        private void frmShowDoctorInfo_Load(object sender, EventArgs e)
        {
            _LoadDoctorData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}