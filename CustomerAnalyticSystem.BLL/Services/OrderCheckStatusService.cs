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
    }
}
