

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
    public partial class frmShowUserInfo : Form
    {
        private readonly clsUser _userService;
        private readonly int _selectedUserId;
        private User _user;

        public frmShowUserInfo(int selectedUserId)
        {
            InitializeComponent();
            _selectedUserId = selectedUserId;

            // إنشاء الـ Context وحقنه في السيرفس (تمت إزالة السيرفسز غير المستخدمة)
            var context = new ClinicManagementSystemContext();
            _userService = new clsUser(context);
        }

        private async Task<bool> _FillDataInDTOs()
        {
            try
            {
                
                _user = await _userService.GetUserByIdAsync(_selectedUserId);

                // إذا كان الـ DTO فارغاً، فهذا يعني أن المستخدم غير موجود في قاعدة البيانات
                if (_user == null)
                {
                    MessageBox.Show(
                        "لم يتم العثور على بيانات هذا المستخدم، قد يكون قد تم حذفه.",
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
                txtNationalNo.Text = _user.Person.NationalNumber;

                // تجميع الاسم الكامل لأن الهيكل الجديد يحتوي على حقول الاسم منفصلة
                txtFullName.Text = $"{_user.Person.FirstName} {_user.Person.SecondName} {_user.Person.ThirdName} {_user.Person.LastName}".Replace("  ", " ").Trim();

                txtGender.Text = _user.Person.Gender == true ? "ذكر" : "أنثى";
                txtBirthDate.Text = _user.Person.DateOfBirth == default ? "-" : _user.Person.DateOfBirth.ToString("yyyy-MM-dd");
                txtPhone.Text = _user.Person.Phone;
                txtEmail.Text = _user.Person.Email;
                txtAddress.Text = _user.Person.Address;

                // 2. بيانات حساب المستخدم (User Fields)
                txtUserId.Text = _user.UserId.ToString();
                txtUsername.Text = _user.Username;
                txtPermissions.Text = _user.Role?.RoleName ?? "غير محدد";
                chkIsActive.Checked = _user.IsActive;

             
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

        private async void _LoadUserData()
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
                MessageBox.Show($"فشل تحميل واجهة المستخدم: {ex.Message}", "خطأ في النظام", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                this.Close();
            }
        }

        private void frmShowUserInfo_Load(object sender, EventArgs e)
        {
            _LoadUserData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
