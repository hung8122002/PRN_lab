﻿using Microsoft.Extensions.DependencyInjection;
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
    /// Interaction logic for WindowOrders.xaml
    /// </summary>
    public partial class WindowOrders : Window
    {
        private OrderViewModel OrderViewModel;
        public WindowOrders()
        {
            InitializeComponent();
            OrderViewModel = ((App)Application.Current).ServiceProvider.GetRequiredService<OrderViewModel>();
            OrderViewModel.SetWindow(this);
            DataContext = OrderViewModel;
        }
    }
}
