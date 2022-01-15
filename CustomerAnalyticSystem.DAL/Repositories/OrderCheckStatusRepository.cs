using CustomerAnalyticSystem.DAL.DTOs;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CustomerAnalyticSystem.DAL
{
    public class OrderCheckStatusRepository
    {
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

