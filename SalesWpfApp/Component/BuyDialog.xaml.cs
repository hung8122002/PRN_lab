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
using System.Windows.Shapes;

namespace SalesWpfApp.Component
{
    /// <summary>
    /// Interaction logic for BuyDialog.xaml
    /// </summary>
    public partial class BuyDialog : Window
    {
        private ProductViewModel ProductViewModel;
        public BuyDialog()
        {
            InitializeComponent();
            ProductViewModel = ((App)Application.Current).ServiceProvider.GetRequiredService<ProductViewModel>();
            DataContext = ProductViewModel;
        }
    }
}
