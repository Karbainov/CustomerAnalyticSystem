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





namespace CustomerAnalyticSystem.DAL
{
   public class OrderRepository
    {
        public List<OrderDTO> GetAllOrders()
        {
            List<OrderDTO> orders = new List<OrderDTO>();
            using(SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                orders = connection.Query<OrderDTO>(Querys.GetAllOrders).ToList();
            }
            return orders;
        }

        public OrderDTO GetOrderById(int id)
        {
            OrderDTO order;
            using(SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                order = connection.QuerySingle<OrderDTO>(Querys.GetOrderById, new { id }
               , commandType: CommandType.StoredProcedure);
            }
            return order;
        }
    }
}
