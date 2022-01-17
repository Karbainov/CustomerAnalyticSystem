using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.DAL;
using CustomerAnalyticSystem.BLL.Models;

namespace CustomerAnalyticSystem.BLL.Services
{
    public class OrderInfoByOrderIdService
    {
        public OrderInfoByOrderIdModel GetOrderInfoByOrderId (int id)
        {
            var service = new OrderCheckStatusRepository();
            var dto = service.FillOrderInfoByOrderId(id);
            var mrMappi = new MapperWork();
            OrderInfoByOrderIdModel result = mrMappi.MapOrderInfoByOrderId(dto);
            return result;
        }
    }
}
