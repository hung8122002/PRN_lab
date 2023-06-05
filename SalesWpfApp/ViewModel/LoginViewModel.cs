using BusinessObject;
using BusinessObject.IService;
using BusinessObject.Service;
using CommunityToolkit.Mvvm.Input;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;

namespace SalesWpfApp.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private IMemberService _memberService;
        private Window _window;
        private MemberObject _memberObject;
        public MemberObject MemberObject
        {
            get { return _memberObject; }
            set
            {
                _memberObject = value;
                OnPropertyChanged(nameof(_memberObject));
            }
        }

        private bool _canLogin;
        public bool CanLogin
        {
            get { return _canLogin; }
            set
            {
                _canLogin = value;
                OnPropertyChanged(nameof(CanLogin));
            }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged("Email");
                CanLogin = !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password);
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
                CanLogin = !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password);
            }
        }

        public LoginViewModel(IMemberService memberService)
        {
            _memberService = memberService;
            LoginCommand = new RelayCommand<MemberObject>(
                p =>
                {
                    if (Email.IsNullOrEmpty() || Password.IsNullOrEmpty())
                    {
                        MessageBox.Show("Email hoặc mật khẩu trống", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    MemberObject = new MemberObject();
                    MemberObject.Email = Email;
                    MemberObject.Password = Password;
                    int check = _memberService.Login(MemberObject);
                    if (check != 0)
                    {
                        App.userId = check;
                        Menu menu = new Menu();
                        menu.Show();
                        _window.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                });
        }

        public RelayCommand<MemberObject> LoginCommand { get; set; }

        public void SetWindow(Window window)
        {
            _window = window;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
