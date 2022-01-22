using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            List<OrderBaseModel> result = map.MapBaseOrder(dto);
            return result;
        }

        public void UpdateCheck (int id, int productId, int orderId, int amount, int mark)
        {
            OrderCheckStatusRepository rep = new OrderCheckStatusRepository();
            rep.UpdateCheck(id, productId, orderId, amount, mark);
        }

        public void DeleteCheck(int id)
        {
            OrderCheckStatusRepository rep = new OrderCheckStatusRepository();
            rep.DeleteCheck(id);
        }

    }
}
