using Microsoft.Extensions.DependencyInjection;
using SalesWpfApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SalesWpfApp
{
    /// <summary>
    /// Interaction logic for WindowMember.xaml
    /// </summary>
    public partial class WindowMember : Window
    {
        private MemberViewModel MemberViewModel;
        public WindowMember()
        {
            InitializeComponent();
            MemberViewModel = ((App)Application.Current).ServiceProvider.GetRequiredService<MemberViewModel>();
            MemberViewModel.SetWindow(this);
            DataContext = MemberViewModel;
        }
    }
}
