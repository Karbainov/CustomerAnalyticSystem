using System;
using System.Collections.Generic;
using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.DAL;
using CustomerAnalyticSystem.DAL.DTOs;

namespace CustomerAnalyticSystem.BLL.Services
{
    public class OrderCheckStatusService
    {
        public List<OrderBaseModel> GetBaseOrderModel()
        {
            MrMappi map = new();
            var service = new OrderCheckStatusRepository();
            var dto = service.GetAllOrders();
            List<OrderBaseModel> result = map.MapBaseOrderList(dto);
            return result;
        }
        public OrderBaseModel GetBaseOrderModelById(int id)
        {
            MrMappi map = new();
            var service = new OrderCheckStatusRepository();
            var dto = service.GetOrderById(id);
            OrderBaseModel result = map.MapBaseOrder(dto);
            return result;
        }
        public void DeleteOrder(int id)
        {
            var service = new OrderCheckStatusRepository();
            service.DeleteOrderById(id);
        }
        public void UpdateOrder(OrderBaseModel updatedOrder)
        {
            MrMappi map = new();
            var dto = map.BackMappingForOrder(updatedOrder);
            var service = new OrderCheckStatusRepository();
            service.UpdateOrderById(dto);
            //вызывается в юайке, мы собираем в интерфейсе модель, потом собираем снова ДТОху БекМапингФорОрдер
            //далее вызывается 
        }
    }
}
