using BusinessObject;
using BusinessObject.IService;
using CommunityToolkit.Mvvm.Input;
using SalesWpfApp.Component;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SalesWpfApp.ViewModel
{
    public class MemberViewModel : INotifyPropertyChanged
    {
        public int userId { get; set; }
        private UpdateDialog updateDiaplog;
        private string action;
        public string Action
        {
            get { return action; }
            set
            {
                action = value;
                OnPropertyChanged(nameof(Action));
            }
        }
        private IMemberService _memberService;
        private static Window _window;
        private MemberObject _memberObject;
        public MemberObject MemberObject
        {
            get { return _memberObject; }
            set
            {
                if (value != null)
                {
                    _memberObject = value;
                    MemberId = value.MemberId;
                    Email = value.Email;
                    CompanyName = value.CompanyName;
                    City = value.City;
                    Country = value.Country;
                    Password = value.Password;
                    CanDelete = true;
                }
                OnPropertyChanged(nameof(MemberObject));
            }
        }

        private int memberID;

        public int MemberId
        {
            get { return memberID; }
            set
            {
                memberID = value;
                OnPropertyChanged(nameof(MemberId));
            }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged(nameof(Email));
                CanAction = !checkNull();
            }
        }

        private string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set
            {
                companyName = value;
                OnPropertyChanged(nameof(CompanyName));
                CanAction = !checkNull();
            }
        }

        private string city;

        public string City
        {
            get { return city; }
            set
            {
                city = value;
                OnPropertyChanged(nameof(City));
                CanAction = !checkNull();
            }
        }

        private string country;

        public string Country
        {
            get { return country; }
            set
            {
                country = value;
                OnPropertyChanged(nameof(Country));
                CanAction = !checkNull();
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
                CanAction = !checkNull();
            }
        }

        private bool _canAction;
        public bool CanAction
        {
            get { return _canAction; }
            set
            {
                _canAction = value;
                OnPropertyChanged(nameof(CanAction));
            }
        }

        private bool _canDelete;
        public bool CanDelete
        {
            get { return _canDelete; }
            set
            {
                _canDelete = value;
                OnPropertyChanged(nameof(CanDelete));
            }
        }

        private bool _canClick;
        public bool CanClick
        {
            get { return _canClick; }
            set
            {
                _canClick = value;
                OnPropertyChanged(nameof(CanClick));
            }
        }

        public MemberViewModel(IMemberService memberService)
        {
            userId = App.userId;
            CanClick = true;
            _memberService = memberService;
            LoadAll();
            DefineComand();
        }

        private void DefineComand()
        {
            AddCommand = new RelayCommand<MemberObject>(
                p =>
                {
                    Email = "";
                    CompanyName = "";
                    City = "";
                    Country = "";
                    Password = "";
                    updateDiaplog = new UpdateDialog();
                    updateDiaplog.Show();
                    CanClick = false;
                    Action = "Add";
                });
            DeleteCommand = new RelayCommand<MemberObject>(
                p =>
                {
                    _memberService.DeleteMember(p);
                    LoadAll();
                });
            UpdateCommand = new RelayCommand<MemberObject>(
                p =>
                {
                    updateDiaplog = new UpdateDialog();
                    updateDiaplog.Show();
                    CanClick = false;
                    Action = "Update";
                });
            CloseDialog = new RelayCommand<MemberObject>(
                p =>
                {
                    updateDiaplog.Close();
                    CanClick = true;
                });
            ActionDialog = new RelayCommand<MemberObject>(
                p =>
                {
                    if(Action == "Add")
                    {
                        MemberObject m = new MemberObject();
                        m.City = City;
                        m.Country = Country;
                        m.Email = Email;
                        m.Password = Password;
                        m.CompanyName = CompanyName;
                        _memberService.AddMember(m);
                        LoadAll();
                        updateDiaplog.Close();
                        CanClick = true;
                    } else
                    {
                        p.City = City;
                        p.Country = Country;
                        p.Email = Email;
                        p.Password = Password;
                        p.CompanyName = CompanyName;
                        _memberService.UpdateMember(p);
                        LoadAll();
                        updateDiaplog.Close();
                        CanClick = true;
                    }
                });
            BackToMenu = new RelayCommand<MemberObject>(
                p =>
                {
                    Menu m = new Menu();
                    m.Show();
                    _window.Close();
                });
        }

        public ObservableCollection<MemberObject> memberObjects { get; set; }

        public ObservableCollection<MemberObject> MemberObjects
        {
            get { return memberObjects; }
            set
            {
                memberObjects = value;
                OnPropertyChanged(nameof(MemberObjects));
            }
        }
        /// <summary>
        /// Load tất cả các member
        /// </summary>
        public void LoadAll()
        {
            MemberObjects = _memberService.GetMembers();
        }

        /// <summary>
        /// Lấy cửa số muốn đóng
        /// </summary>
        /// <param name="window"></param>
        public void SetWindow(Window window)
        {
            _window = window;
        }

        /// <summary>
        /// Kiểm tra có trường dữ liệu nào null không
        /// </summary>
        /// <returns></returns>
        public bool checkNull()
        {
            return String.IsNullOrEmpty(Email) || String.IsNullOrEmpty(CompanyName) || String.IsNullOrEmpty(City) || String.IsNullOrEmpty(Country) || String.IsNullOrEmpty(Password);
        }

        public RelayCommand<MemberObject> DeleteCommand { get; set; }
        public RelayCommand<MemberObject> AddCommand { get; set; }
        public RelayCommand<MemberObject> UpdateCommand { get; set; }
        public RelayCommand<MemberObject> CloseDialog { get; set; }
        public RelayCommand<MemberObject> ActionDialog { get; set; }
        public RelayCommand<MemberObject> BackToMenu { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
