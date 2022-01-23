using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.DAL;
using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.BLL.Configs;

namespace CustomerAnalyticSystem.BLL.Services
{
    public class OrderInfoByOrderIdService
    {
        public OrderInfoByOrderIdModel GetOrderInfoByOrderId(int id)
        {
            MrMappi map = new();
            var service = new OrderCheckStatusRepository();
            var dto = service.FillOrderInfoByOrderId(id);
            OrderInfoByOrderIdModel result = map.MapOrderInfoByOrderId(dto);
            return result;
        }


    }
}
