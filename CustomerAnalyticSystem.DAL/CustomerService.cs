using CustomerAnalyticSystem.DAL.DTOs;
using System;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.DAL;

namespace CustomerAnalyticSystem.DAL
{
    public class CustomerDapper
    {
        public List<CustomerDTO> GetAllCustomerService()
        {
            List<CustomerDTO> customers = new List<CustomerDTO>();

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                customers = connection.Query<CustomerDTO>(Querys.GetAllCustomer).ToList();
            }
            return customers;
        }
    }
}