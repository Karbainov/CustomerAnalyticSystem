using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.DAL;

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
