using System;
using System.Windows.Forms;
using ClinicBusiness.DTO.UsersDTOs;
using ClinicBusiness.Models;
using ClinicBusiness.Services;

namespace ClinicManagementSystem
{
    public partial class frmChangePassword : Form
    {
        private readonly UserViewDTO _currentUser;
        private readonly clsUser _userService; // استبدله بطريقة حقن السيرفيس المتبعة في مشروعك
        private bool _isSaving = false;

        // نمرر المستخدم الحالي عبر المشيّد
        public frmChangePassword(UserViewDTO currentUser, clsUser userService)
        {
            InitializeComponent();
            _currentUser = currentUser;
            _userService = userService;

            // إعداد خصائص حقول كلمة المرور لإخفاء النص تلقائياً
            txtOldPassword.UseSystemPasswordChar = true;
            txtNewPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_isSaving) return;

            // 1. التحقق من المدخلات
            if (!ValidateForm()) return;

            try
            {
                _isSaving = true;
                btnSave.Enabled = false;

                // 2. استدعاء السيرفيس لتحديث كلمة المرور
                bool isSuccess = await _userService.ChangePasswordAsync(
                    _currentUser.UserId,
                    txtOldPassword.Text.Trim(),
                    txtNewPassword.Text.Trim()
                );

                if (isSuccess)
                {
                    MessageBox.Show("تم تغيير كلمة المرور بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // إغلاق الشاشة بعد النجاح
                }
                else
                {
                    MessageBox.Show("كلمة المرور الحالية غير صحيحة، يرجى المحاولة مرة أخرى.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOldPassword.Focus();
                    txtOldPassword.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تغيير كلمة المرور: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _isSaving = false;
                btnSave.Enabled = true;
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtOldPassword.Text))
            {
                MessageBox.Show("يرجى إدخال كلمة المرور الحالية.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOldPassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNewPassword.Text) || txtNewPassword.Text.Length < 6)
            {
                MessageBox.Show("يرجى إدخال كلمة مرور جديدة لا تقل عن 6 خانات.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return false;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("كلمة المرور الجديدة وغير متطابقة مع تأكيد كلمة المرور.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return false;
            }

            // حماية إضافية: منع المستخدم من إعادة كتابة نفس كلمته القديمة كجديدة
            if (txtOldPassword.Text.Trim() == txtNewPassword.Text.Trim())
            {
                MessageBox.Show("كلمة المرور الجديدة يجب أن تكون مختلفة عن كلمة المرور الحالية.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}