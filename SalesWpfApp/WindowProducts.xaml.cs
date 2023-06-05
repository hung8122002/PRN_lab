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
    /// Interaction logic for WindowProducts.xaml
    /// </summary>
    public partial class WindowProducts : Window
    {
        private ProductViewModel ProductViewModel;
        public WindowProducts()
        {
            InitializeComponent();
            ProductViewModel = ((App)Application.Current).ServiceProvider.GetRequiredService<ProductViewModel>();
            ProductViewModel.SetWindow(this);
            DataContext = ProductViewModel;
        }
    }
}
