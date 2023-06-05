using Data_Layer.IRepository;
using Data_Layer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Repository
{
    public class ProductRepository : IProductRepository
    {
        private FstoreContext _context;

        public ProductRepository()
        {
            _context = FstoreContext.GetInstance();
        }

        public void AddProduct(Product product)
        {
            Product m = new Product();
            m.ProductName = product.ProductName;
            m.UnitPrice = product.UnitPrice;
            m.UnitStock = product.UnitStock;
            m.CategoryId = product.CategoryId;
            m.Weight = product.Weight;
            _context.Products.Add(m);
            _context.SaveChanges();
        }

        public void BuyProduct(OrderDetail detail, int userId)
        {
            Order m = new Order();
            m.MemberId = userId;
            m.OrderDate = DateTime.Now;
            _context.Orders.Add(m);
            _context.SaveChanges();
            detail.OrderId = m.OrderId;
            _context.OrderDetails.Add(detail);
            _context.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            Product m = _context.Products.FirstOrDefault(p => p.ProductId == product.ProductId);
            if (m != null)
            {
                _context.Products.Remove(m);
                _context.SaveChanges();
            }
        }

        public ObservableCollection<Product> GetAll()
        {
            var product = _context.Products.ToList();
            var observableProducts = new ObservableCollection<Product>(product);
            return observableProducts;
        }

        public Product GetProductById(int id)
        {
            Product m = _context.Products.FirstOrDefault(p => p.ProductId == id);
            return m;
        }

        public void UpdateProduct(Product product)
        {
            Product m = _context.Products.FirstOrDefault(p => p.ProductId == product.ProductId);
            if (m != null)
            {
                m.ProductName = product.ProductName;
                m.UnitPrice = product.UnitPrice;
                m.UnitStock = product.UnitStock;
                m.CategoryId = product.CategoryId;
                m.Weight = product.Weight;
                _context.SaveChanges();
            }
        }
    }
}
