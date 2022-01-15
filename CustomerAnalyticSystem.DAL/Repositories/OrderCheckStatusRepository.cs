using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using CustomerAnalyticSystem.DAL;
using CustomerAnalyticSystem.DAL.DTOs;
using System.Data;
using CustomerAnalyticSystem.DAL;

namespace CustomerAnalyticSystem.DAL
{
    public class OrderCheckStatusRepository
    {
        public List<OrderDTO> GetAllOrders()
        {
            List<OrderDTO> orders = new List<OrderDTO>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                orders = connection.Query<OrderDTO>(Queries.GetAllOrders).ToList();
            }
            return orders;
        }

        public OrderDTO GetOrderById(int id)
        {
            OrderDTO order;
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                order = connection.QuerySingle<OrderDTO>(Queries.GetOrderById, new { id }
               , commandType: CommandType.StoredProcedure);
            }
            return order;
        }

        public void AddOrder(int CustomerId, string Date, int StatusId, int Cost)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.Query<OrderDTO>(Queries.AddOrder, new { CustomerId, Date, StatusId, Cost }
                , commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteOrderById(int id) // хз че с ним делать, удалять нельзя изза ссылки
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.Query<OrderDTO>(Queries.DeleteOrderById, new { id }
                , commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateOrderById(int id, int CustomerId, string Date, int StatusId, int Cost)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.Query<GradeDTO>(Queries.UpdateOrderById, new { id, CustomerId, Date, StatusId, Cost }
                , commandType: CommandType.StoredProcedure);
            }
        }

        public List<StatusDTO> GetAllStatus()
        {
            List<StatusDTO> status = new List<StatusDTO>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                status = connection.Query<StatusDTO>(Queries.GetAllStatus).ToList();
            }
            return status;
        }

        public StatusDTO GetStatusById(int id)
        {
            StatusDTO status;
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                status = connection.QuerySingle<StatusDTO>(Queries.GetStatusById, new { id }
               , commandType: CommandType.StoredProcedure);
            }
            return status;
        }

        public void AddStatus(string Name)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.Query<StatusDTO>(Queries.AddStatus, new { Name }
                , commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteStatusById(int id)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.Query<StatusDTO>(Queries.DeleteStatusById, new { id }
                , commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateStatusById(int id, string Name)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.Query<StatusDTO>(Queries.UpdateStatusById, new { id, Name }
                , commandType: CommandType.StoredProcedure);
            }
        }

        public AllOrderInfoByOrderId FillOrderInfoByOrderId(int id)
        {
            AllOrderInfoByOrderId concreteOrder = null;

            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Query<AllOrderInfoByOrderId, CheckDTO, AllOrderInfoByOrderId>(Querys.GetAllOrderInfoByOrderId,
                    (orderInfo, item) =>
                {
                    if (concreteOrder == null)
                    {
                        concreteOrder = orderInfo;
                        concreteOrder.Items = new();
                    }
                    concreteOrder.Items.Add(item);
                    return concreteOrder;
                }
                , new { Id = id }
                , commandType: CommandType.StoredProcedure
                , splitOn: "OrderId,Id");
            }
            return concreteOrder;
        }

        //public AllOrderInfoByOrderId FillOrderInfoByOrderId(int id)
        //{
        //    AllOrderInfoByOrderId concreteOrder = null;

        //    string connectionString = ConnectionString.Connection;
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Query<AllOrderInfoByOrderId, CheckWithProductAndGroupInfoDTO, AllOrderInfoByOrderId>(Queries.GetAllOrderInfoByOrderId,
        //            (orderInfo, item)=>
        //        {
        //            if (concreteOrder == null)
        //            {
        //                concreteOrder = orderInfo;
        //                concreteOrder.Items = new();
        //            }
        //            concreteOrder.Items.Add(item);
        //            return concreteOrder;
        //        }
        //        , new { Id = id }
        //        , commandType: CommandType.StoredProcedure
        //        , splitOn:"OrderId,Id");
        //    }
        //    return concreteOrder;
        //}
    }
}

