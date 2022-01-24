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
            OrderRepository rep = new OrderRepository();
            rep.UpdateCheck(id, productId, orderId, amount, mark);
        }

        public void DeleteCheck(int id)
        {
            OrderRepository rep = new OrderRepository();
            rep.DeleteCheck(id);
        }


        public List<OrderBaseModel> GetBaseOrderModel()
        {
            BestMapper map = new();
            var service = new OrderRepository();
            var dto = service.GetOrderModel();
            List<OrderBaseModel> result = map.MapBaseOrder(dto);
            return result;
        }

        public List<StatusModel> GetAllStatus()
        {
            BestMapper map = new();
            var service = new OrderRepository();
            var dto = service.GetAllStatus();
            List<StatusModel> result = map.MapFromStatus(dto);
            return result;
        }

        public void AddStatus(string name)
        {
            BestMapper map = new();
            var service = new OrderRepository();
            service.AddStatus(name);
        }

        public void DeleteStatusById(int id)
        {
            BestMapper map = new();
            var service = new OrderRepository();
            service.DeleteStatusById(id);
        }

        public void UpdateStatusById(int id, string name)
        {
            BestMapper map = new();
            var service = new OrderRepository();
            service.UpdateStatusById(id, name);
        }

        public List<OrderBaseModel> GetAllOrdersByStatusId(int id)
        {
            BestMapper map = new();
            var service = new OrderRepository();
            var dto = service.GetAllOrdersByStatusId(id);
            List<OrderBaseModel> result = map.MapFromOrderDTOToOrderBaseModel(dto);
            return result;
        }

        public List<CheckByOrderIdModel> GetCheckByOrderId(int id)
        {
            BestMapper map = new();
            var service = new OrderRepository();
            var dto = service.GetCheckByOrderId(id);
            List<CheckByOrderIdModel> result = map.MapCheckByOrderId(dto);
            return result;
        }



    }
}
