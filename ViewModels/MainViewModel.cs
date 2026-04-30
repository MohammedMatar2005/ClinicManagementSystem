using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ClinicManagementApplication.Infrastructure;

namespace ClinicManagementApplication.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private string _currentPage;
        public string CurrentPage
        {
            get => _currentPage;
            set
            {
                _currentPage = value;
                OnPropertyChanged(); // إشعار الواجهة بالتغيير
            }
        }

        public ICommand NavigateCommand { get; }

        public MainViewModel()
        {
            CurrentPage = "home"; // الصفحة الافتراضية
            NavigateCommand = new RelayCommand((p) => CurrentPage = p.ToString());
        }
    }
}
