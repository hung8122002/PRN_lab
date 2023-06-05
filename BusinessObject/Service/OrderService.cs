using AutoMapper;
using BusinessObject.IService;
using Data_Layer.IRepository;
using Data_Layer.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Service
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderService;
        private IMapper _mapper;

        public OrderService(IOrderRepository orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        public void DeleteOrder(OrderObject order)
        {
            var m = _mapper.Map<Order>(order);
            _orderService.DeleteOrder(m);
        }

        public ObservableCollection<OrderObject> GetAll()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Order, OrderObject>();
            });
            var mapper = config.CreateMapper();
            var list = mapper.Map<ObservableCollection<OrderObject>>(_orderService.GetAll());
            return list;
        }

        public OrderDetailObject GetOrderDetail(int oderId)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<OrderDetail, OrderDetailObject>();
            });
            var mapper = config.CreateMapper();
            var p = mapper.Map<OrderDetailObject>(_orderService.GetOrderDetail(oderId));
            return p;
        }

        public void UpdateOrder(OrderDetailObject orderDetail, OrderObject order)
        {
            var m = _mapper.Map<OrderDetail>(orderDetail);
            var m1 = _mapper.Map<Order>(order);
            _orderService.UpdateOrder(m, m1);
        }
    }
}
