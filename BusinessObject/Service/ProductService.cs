using AutoMapper;
using AutoMapper.Execution;
using BusinessObject.IService;
using Data_Layer.IRepository;
using Data_Layer.Models;
using Data_Layer.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Service
{
    public class ProductService : IProductService
    {
        private IProductRepository _productService;
        private IMapper _mapper;

        public ProductService(IProductRepository productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public void AddProduct(ProductObject product)
        {
            var m = _mapper.Map<Product>(product);
            _productService.AddProduct(m);
        }

        public void BuyProduct(OrderDetailObject detail, int userId)
        {
            var m = _mapper.Map<OrderDetail>(detail);
            _productService.BuyProduct(m, userId);
        }

        public void DeleteProduct(ProductObject product)
        {
            var m = _mapper.Map<Product>(product);
            _productService.DeleteProduct(m);
        }

        public ObservableCollection<ProductObject> GetAll()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Product, ProductObject>();
            });
            var mapper = config.CreateMapper();
            var list = mapper.Map<ObservableCollection<ProductObject>>(_productService.GetAll());
            return list;
        }

        public ProductObject GetProductById(int id)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Product, ProductObject>();
            });
            var mapper = config.CreateMapper();
            var p = mapper.Map<ProductObject>(_productService.GetProductById(id));
            return p;
        }

        public void UpdateProduct(ProductObject product)
        {
            var m = _mapper.Map<Product>(product);
            _productService.UpdateProduct(m);
        }
    }
}
