using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.DAL;
using System.Collections.Generic;

namespace CustomerAnalyticSystem.BLL.Services
{
    public class OrderCheckStatusService
    {
        //public List<OrderBaseModel> GetBaseOrderModel()
        //{
        //    MrMappi map = new();
        //    var service = new OrderCheckStatusRepository();
        //    var dto = service.GetAllOrders();
        //    List<OrderBaseModel> result = map.MapBaseOrder(dto);
        //    return result;
        //}

        public void UpdateCheck(int id, int productId, int orderId, int amount, int mark)
        {
            OrderCheckStatusRepository rep = new OrderCheckStatusRepository();
            rep.UpdateCheck(id, productId, orderId, amount, mark);
        }

        public void DeleteCheck(int id)
        {
            OrderCheckStatusRepository rep = new OrderCheckStatusRepository();
            rep.DeleteCheck(id);
        }


        public List<OrderBaseModel> GetBaseOrderModel()
        {
            MrMappi map = new();
            var service = new OrderCheckStatusRepository();
            var dto = service.GetOrderModel();
            List<OrderBaseModel> result = map.MapBaseOrder(dto);
            return result;
        }

        public List<StatusModel> GetAllStatus()
        {
            MrMappi map = new();
            var service = new OrderCheckStatusRepository();
            var dto = service.GetAllStatus();
            List<StatusModel> result = map.MapFromStatus(dto);
            return result;
        }

        public void AddStatus(string name)
        {
            MrMappi map = new();
            var service = new OrderCheckStatusRepository();
            service.AddStatus(name);
        }

        public void DeleteStatusById(int id)
        {
            MrMappi map = new();
            var service = new OrderCheckStatusRepository();
            service.DeleteStatusById(id);
        }

        public void UpdateStatusById(int id, string name)
        {
            MrMappi map = new();
            var service = new OrderCheckStatusRepository();
            service.UpdateStatusById(id, name);
        }

        public List<OrderBaseModel> GetAllOrdersByStatusId(int id)
        {
            MrMappi map = new();
            var service = new OrderCheckStatusRepository();
            var dto = service.GetAllOrdersByStatusId(id);
            List<OrderBaseModel> result = map.MapFromOrderDTOToOrderBaseModel(dto);
            return result;
        }

        public List<CheckByOrderIdModel> GetCheckByOrderId(int id)
        {
            MrMappi map = new();
            var service = new OrderCheckStatusRepository();
            var dto = service.GetCheckByOrderId(id);
            List<CheckByOrderIdModel> result = map.MapCheckByOrderId(dto);
            return result;
        }

        public void DeleteOrderById(int id)
        {
            OrderCheckStatusRepository rep = new OrderCheckStatusRepository();
            rep.DeleteOrderById(id);
        }

    }
}
