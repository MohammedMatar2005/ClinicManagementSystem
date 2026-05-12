using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ClinicManagementApplication.Infrastructure
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// إطلاق حدث تنبيه الواجهة بتغير القيمة
        /// </summary>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// الدالة السحرية التي تحل مشكلة الإيرور وتختصر الكود
        /// تقوم بمقارنة القيمة القديمة بالجديدة، وتحديثها، ثم تنبيه الواجهة في سطر واحد
        /// </summary>
        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
                return false;

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        // خاصية للتحكم في "حالة التحميل" تظهر في كل الواجهات
        private bool _isLoading;
        public bool IsLoading
        {
            get => _isLoading;
            set => SetProperty(ref _isLoading, value);
        }

        // خاصية للتحكم في "عنوان الصفحة" إذا كنت تريد عرض اسم الشاشة ديناميكياً
        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
    }
}