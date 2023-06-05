using Data_Layer.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.IService
{
    public interface IProductService
    {
        public void AddProduct(ProductObject product);
        public void UpdateProduct(ProductObject product);
        public void DeleteProduct(ProductObject product);

        public void BuyProduct(OrderDetailObject detail, int userId);

        public ProductObject GetProductById(int id);

        public ObservableCollection<ProductObject> GetAll();
    }
}
