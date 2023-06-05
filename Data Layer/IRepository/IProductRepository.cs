using Data_Layer.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.IRepository
{
    public interface IProductRepository
    {
        public void AddProduct(Product product);
        public void UpdateProduct(Product product);
        public void DeleteProduct(Product product);
        public void BuyProduct(OrderDetail detail, int userId);

        public Product GetProductById(int id);

        public ObservableCollection<Product> GetAll();
    }
}
