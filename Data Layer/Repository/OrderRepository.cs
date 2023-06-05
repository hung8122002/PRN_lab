using Data_Layer.IRepository;
using Data_Layer.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private FstoreContext _context;

        public OrderRepository()
        {
            _context = FstoreContext.GetInstance();
        }

        public void DeleteOrder(Order order)
        {
            OrderDetail o = _context.OrderDetails.FirstOrDefault(p => p.OrderId == order.OrderId);
            Order o1 = _context.Orders.FirstOrDefault(p => p.OrderId == order.OrderId);
            if (o != null)
            {
                _context.OrderDetails.Remove(o);
            }
            if (o1 != null)
            {
                _context.Orders.Remove(o1);
                _context.SaveChanges();
            }
        }

        public ObservableCollection<Order> GetAll()
        {
            var order = _context.Orders.ToList();
            var observableOrders = new ObservableCollection<Order>(order);
            return observableOrders;
        }

        public OrderDetail GetOrderDetail(int oderId)
        {
            return _context.OrderDetails.FirstOrDefault(p => p.OrderId == oderId);
        }

        public void UpdateOrder(OrderDetail OrderDetail, Order order)
        {
            OrderDetail o = _context.OrderDetails.FirstOrDefault(p => p.OrderId == order.OrderId);
            Order o1 = _context.Orders.FirstOrDefault(p => p.OrderId == order.OrderId);
            if (o != null)
            {
                o.Quantity = OrderDetail.Quantity;
                o.Discount = OrderDetail.Discount;
            }
            if (o1 != null)
            {
                o1.RequireDare = order.RequireDare;
                o1.ShippingDate = order.ShippingDate;
                o1.Freight = order.Freight;
            }
            _context.SaveChanges();
        }
    }
}
