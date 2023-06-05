using Microsoft.Extensions.DependencyInjection;
using SalesWpfApp.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SalesWpfApp.Component
{
    public partial class UpdateDialog : Window
    {
        private MemberViewModel MemberViewModel;
        public UpdateDialog()
        {
            InitializeComponent();
            MemberViewModel = ((App)Application.Current).ServiceProvider.GetRequiredService<MemberViewModel>();
            DataContext = MemberViewModel;
        }
    }
}
