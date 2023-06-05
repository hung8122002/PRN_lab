using Data_Layer.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.IService
{
    public interface IOrderService
    {
        public void UpdateOrder(OrderDetailObject orderDetail, OrderObject order);
        public void DeleteOrder(OrderObject order);
        public ObservableCollection<OrderObject> GetAll();
        public OrderDetailObject GetOrderDetail(int oderId);
    }
}
