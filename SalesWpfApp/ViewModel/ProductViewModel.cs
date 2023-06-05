using BusinessObject.IService;
using BusinessObject;
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
    internal class ProductViewModel : INotifyPropertyChanged
    {
        private ProductDialog productDiaplog;
        private BuyDialog buyDiaplog;
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
        private IProductService _productService;
        private Window _window;
        private ProductObject _productObject;
        public ProductObject ProductObject
        {
            get { return _productObject; }
            set
            {
                if (value != null)
                {
                    _productObject = value;
                    ProductId = value.ProductId;
                    CategoryId = value.CategoryId;
                    ProductName = value.ProductName;
                    Weight = value.Weight;
                    UnitPrice = value.UnitPrice;
                    UnitStock = value.UnitStock;
                    CanDelete = true;
                }
                OnPropertyChanged(nameof(ProductObject));
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

        private int categoryId;

        public int CategoryId
        {
            get { return categoryId; }
            set
            {
                categoryId = value;
                OnPropertyChanged(nameof(CategoryId));
                CanAction = !checkNull();
            }
        }

        private string productName;

        public string ProductName
        {
            get { return productName; }
            set
            {
                productName = value;
                OnPropertyChanged(nameof(ProductName));
                CanAction = !checkNull();
            }
        }

        private string weight;

        public string Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                OnPropertyChanged(nameof(Weight));
                CanAction = !checkNull();
            }
        }

        private decimal unitPrice;

        public decimal UnitPrice
        {
            get { return unitPrice; }
            set
            {
                unitPrice = value;
                OnPropertyChanged(nameof(UnitPrice));
                CanAction = !checkNull();
            }
        }

        private int unitStock;

        public int UnitStock
        {
            get { return unitStock; }
            set
            {
                unitStock = value;
                OnPropertyChanged(nameof(UnitStock));
                CanAction = !checkNull();
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
                CanBuy = Quantity > 0;
            }
        }

        private int discount;

        public int Discount
        {
            get { return discount; }
            set
            {
                discount = value;
                OnPropertyChanged(nameof(Discount));
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

        private bool _canBuy;
        public bool CanBuy
        {
            get { return _canBuy; }
            set
            {
                _canBuy = value;
                OnPropertyChanged(nameof(CanBuy));
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

        public ProductViewModel(IProductService productService)
        {
            CanClick = true;
            _productService = productService;
            LoadAll();
            DefineComand();
        }

        private void DefineComand()
        {
            AddCommand = new RelayCommand<ProductObject>(
                p =>
                {
                    CategoryId = 0;
                    ProductName = "";
                    Weight = "";
                    UnitPrice = 0;
                    UnitStock = 0;
                    productDiaplog = new ProductDialog();
                    productDiaplog.Show();
                    CanClick = false;
                    Action = "Add";
                });
            DeleteCommand = new RelayCommand<ProductObject>(
                p =>
                {
                    _productService.DeleteProduct(p);
                    LoadAll();
                });
            UpdateCommand = new RelayCommand<ProductObject>(
                p =>
                {
                    productDiaplog = new ProductDialog();
                    productDiaplog.Show();
                    CanClick = false;
                    Action = "Update";
                });
            CloseDialog = new RelayCommand<ProductObject>(
                p =>
                {
                    if (productDiaplog != null)
                    {
                        productDiaplog.Close();

                    }
                    if (buyDiaplog != null)
                    {
                        buyDiaplog.Close();
                    }
                    CanClick = true;
                });
            ActionDialog = new RelayCommand<ProductObject>(
                p =>
                {
                    if (Action == "Add")
                    {
                        ProductObject m = new ProductObject();
                        m.CategoryId = CategoryId;
                        m.ProductName = ProductName;
                        m.Weight = Weight;
                        m.UnitPrice = UnitPrice;
                        m.UnitStock = UnitStock;
                        _productService.AddProduct(m);
                        LoadAll();
                        productDiaplog.Close();
                        CanClick = true;
                    }
                    else
                    {
                        p.CategoryId = CategoryId;
                        p.ProductName = ProductName;
                        p.Weight = Weight;
                        p.UnitPrice = UnitPrice;
                        p.UnitStock = UnitStock;
                        _productService.UpdateProduct(p);
                        LoadAll();
                        productDiaplog.Close();
                        CanClick = true;
                    }
                });
            BuyCommand = new RelayCommand<ProductObject>(
                p =>
                {
                    buyDiaplog = new BuyDialog();
                    Quantity = 0;
                    buyDiaplog.Show();
                });
            BuyProductCommand = new RelayCommand<ProductObject>(
                p =>
                {
                    OrderDetailObject o = new OrderDetailObject();
                    o.ProductId = ProductId;
                    o.UnitPrice = UnitPrice;
                    o.Quantity = Quantity;
                    o.Discount = Discount;
                    _productService.BuyProduct(o, App.userId);
                    MessageBox.Show("Buy Successfully", "Dialog", MessageBoxButton.OK, MessageBoxImage.Information);
                    buyDiaplog.Close();
                    CanClick = true;
                });
            BackToMenu = new RelayCommand<ProductObject>(
                p =>
                {
                    Menu menu = new Menu();
                    menu.Show();
                    _window.Close();
                });
        }

        public ObservableCollection<ProductObject> productObjects { get; set; }

        public ObservableCollection<ProductObject> ProductObjects
        {
            get { return productObjects; }
            set
            {
                productObjects = value;
                OnPropertyChanged(nameof(ProductObjects));
            }
        }
        /// <summary>
        /// Load tất cả các member
        /// </summary>
        public void LoadAll()
        {
            ProductObjects = _productService.GetAll();
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
            return String.IsNullOrEmpty(CategoryId.ToString()) || String.IsNullOrEmpty(ProductName) || String.IsNullOrEmpty(Weight) || String.IsNullOrEmpty(UnitPrice.ToString()) || String.IsNullOrEmpty(UnitStock.ToString());
        }

        public RelayCommand<ProductObject> DeleteCommand { get; set; }
        public RelayCommand<ProductObject> AddCommand { get; set; }
        public RelayCommand<ProductObject> UpdateCommand { get; set; }
        public RelayCommand<ProductObject> CloseDialog { get; set; }
        public RelayCommand<ProductObject> ActionDialog { get; set; }
        public RelayCommand<ProductObject> BuyCommand { get; set; }
        public RelayCommand<ProductObject> BuyProductCommand { get; set; }
        public RelayCommand<ProductObject> BackToMenu { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
