using Data_Layer.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.IRepository
{
    public interface IOrderRepository
    {
        public void UpdateOrder(OrderDetail orderDetail, Order order);
        public void DeleteOrder(Order order);
        public ObservableCollection<Order> GetAll();
        public OrderDetail GetOrderDetail(int oderId);
    }
}
