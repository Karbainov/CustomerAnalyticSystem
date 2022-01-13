using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.DAL.DTOs;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CustomerAnalyticSystem.DAL
{
    public class FillOrderInfo
    {
        public AllOrderInfoByOrderId FillOrderInfoByOrderId()
        {
            int id = 1;
            AllOrderInfoByOrderId concreteOrder = null;

            string query = "GetAllOrderInfoByOrderId";
            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Query<AllOrderInfoByOrderId, CheckDTO, AllOrderInfoByOrderId>(query,(orderInfo, item)=>
                {
                    if (concreteOrder == null)
                    {
                        concreteOrder = orderInfo;
                        concreteOrder.Items = new();
                    }
                    concreteOrder.Items.Add(item);
                    return concreteOrder;
                }
                ,new { Id = id },
                commandType: CommandType.StoredProcedure
                ,splitOn:"OrderId,Id");
            }
            return concreteOrder;
        }
    }
}//сначала это потом модель потом мапер потом метод для UI

