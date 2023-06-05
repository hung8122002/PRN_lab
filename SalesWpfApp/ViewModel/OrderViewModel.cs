using BusinessObject.IService;
using BusinessObject;
using SalesWpfApp.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Data_Layer.Models;
using System.Windows.Media.Media3D;
using BusinessObject.Service;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;

namespace SalesWpfApp.ViewModel
{
    internal class OrderViewModel : INotifyPropertyChanged
    {
        private OrderDetailDialog orderDetailDiaplog;

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
        private IOrderService _orderService;
        private static Window _window;
        private OrderObject _orderObject;
        public OrderObject OrderObject
        {
            get { return _orderObject; }
            set
            {
                if (value != null)
                {
                    _orderObject = value;
                    OrderId = value.OrderId;
                    MemberId = value.MemberId;
                    OrderDate = value.OrderDate;
                    ShippedDate = value.ShippingDate;
                    RequiredDate = value.RequireDare;
                    Freight = value.Freight;
                    CanDelete = true;
                }
                OnPropertyChanged(nameof(OrderObject));
            }
        }

        private int orderId;
        public int OrderId
        {
            get { return orderId; }
            set
            {
                orderId = value;
                OnPropertyChanged(nameof(OrderId));
            }
        }

        private int memberId;
        public int MemberId
        {
            get { return memberId; }
            set
            {
                memberId = value;
                OnPropertyChanged(nameof(MemberId));
            }
        }

        private DateTime orderDate;
        public DateTime OrderDate
        {
            get { return orderDate; }
            set
            {
                orderDate = value;
                OnPropertyChanged(nameof(OrderDate));
            }
        }

        private DateTime? requiredDate;
        public DateTime? RequiredDate
        {
            get { return requiredDate; }
            set
            {
                requiredDate = value;
                OnPropertyChanged(nameof(RequiredDate));
            }
        }

        private DateTime? shippedDate;
        public DateTime? ShippedDate
        {
            get { return shippedDate; }
            set
            {
                shippedDate = value;
                OnPropertyChanged(nameof(ShippedDate));
            }
        }

        private Decimal? freight;
        public Decimal? Freight
        {
            get { return freight; }
            set
            {
                freight = value;
                OnPropertyChanged(nameof(Freight));
            }
        }

        private int productId;
        public int ProductId
        {
            get { return productId; }
            set
            {
                productId = value;
                OnPropertyChanged(nameof(ProductId));
            }
        }

        private Decimal unitPrice;
        public Decimal UnitPrice
        {
            get { return unitPrice; }
            set
            {
                unitPrice = value;
                OnPropertyChanged(nameof(UnitPrice));
            }
        }

        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }

        private double discount;
        public double Discount
        {
            get { return discount; }
            set
            {
                discount = value;
                OnPropertyChanged(nameof(Discount));
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

        public OrderViewModel(IOrderService orderService)
        {
            CanClick = true;
            _orderService = orderService;
            LoadAll();
            DefineCommand();
        }

        private void DefineCommand()
        {
            CloseDialog = new RelayCommand<OrderObject>(
                p =>
                {
                    orderDetailDiaplog.Close();
                    CanClick = true;
                });
            UpdateCommand = new RelayCommand<OrderObject>(
                p =>
                {
                    orderDetailDiaplog = new OrderDetailDialog();
                    OrderDetailObject o = new OrderDetailObject();
                    o = _orderService.GetOrderDetail(OrderId);
                    UnitPrice = o.UnitPrice;
                    Quantity = o.Quantity;
                    Discount = o.Discount;
                    orderDetailDiaplog.Show();
                    CanClick = false;
                    Action = "Update";
                });
            UpdateOrderCommand = new RelayCommand<OrderObject>(
                p =>
                {
                    p.RequireDare = RequiredDate;
                    p.ShippingDate = ShippedDate;
                    p.Freight = Freight;
                    OrderDetailObject o = new OrderDetailObject();
                    o.Discount = Discount;
                    o.Quantity = Quantity;
                    _orderService.UpdateOrder(o, p);
                    orderDetailDiaplog.Close();
                    CanClick = true;
                    LoadAll();
                });
            DeleteCommand = new RelayCommand<OrderObject>(
                p =>
                {
                    _orderService.DeleteOrder(p);
                    LoadAll();
                });
            BackToMenu = new RelayCommand<OrderObject>(
                p =>
                {
                    Menu menu = new Menu();
                    menu.Show();
                    _window.Close();
                });
        }

        private ObservableCollection<OrderObject> orderObjects { get; set; }

        public ObservableCollection<OrderObject> OrderObjects
        {
            get { return orderObjects; }
            set
            {
                orderObjects = value;
                OnPropertyChanged(nameof(OrderObjects));
            }
        }
        /// <summary>
        /// Load tất cả các member
        /// </summary>
        public void LoadAll()
        {
            OrderObjects = _orderService.GetAll();
        }

        public void SetWindow(Window window)
        {
            _window = window;
        }

        public RelayCommand<OrderObject> DeleteCommand { get; set; }
        public RelayCommand<OrderObject> UpdateCommand { get; set; }
        public RelayCommand<OrderObject> UpdateOrderCommand { get; set; }
        public RelayCommand<OrderObject> CloseDialog { get; set; }
        public RelayCommand<OrderObject> BackToMenu { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
