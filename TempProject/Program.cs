using System;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using CustomerAnalyticSystem.DAL;

namespace TempProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CustomerAnalyticSystem.DAL.DTOs.ProductDTO> products;
            string query = "EXEC GetAllProduct";
            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               products = connection.Query<CustomerAnalyticSystem.DAL.DTOs.ProductDTO>(query).ToList();
            }
            foreach (var p in products)
            {
                Console.WriteLine((CustomerAnalyticSystem.DAL.DTOs.ProductDTO)p);
            }
        }
    }
}
