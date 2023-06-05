using BusinessObject;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SalesWpfApp.ViewModel
{
    class MenuViewModel
    {
        private WindowOrders windowOrder;
        private WindowMember windowMember;
        private WindowProducts windowLProduct;
        private static Window _window;
        
        public MenuViewModel()
        {
            Product = new RelayCommand<Object>(
                p =>
                {
                    windowLProduct = new WindowProducts();
                    windowLProduct.Show();
                    if (_window != null)
                    {
                        _window.Close();
                    }
                });
            Member = new RelayCommand<Object>(
                p =>
                {
                    windowMember = new WindowMember();
                    windowMember.Show();
                    _window.Close();
                });
            Order = new RelayCommand<Object>(
                p =>
                {
                    windowOrder = new WindowOrders();
                    windowOrder.Show();
                    _window.Close();
                });
        }
        public RelayCommand<object> Product { get; set; }
        public RelayCommand<object> Member { get; set; }
        public RelayCommand<object> Order { get; set; }

        public void SetWindow(Window window)
        {
            _window = window;
        }
    }
}
