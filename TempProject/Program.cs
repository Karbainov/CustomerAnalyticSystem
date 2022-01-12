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
        public static void FillCustomerDTO()
        {
            List<CustomerAnalyticSystem.DAL.DTOs.CustomerDTO> customers;

            string query = "EXEC GetAllCustomers";
            string connectionString = @"Data Source=LAPTOP-JUFI6541;Initial Catalog=CreateAnalyticSystem;Integrated Security=True;Persist Security Info=False;
                                       Pooling=False;MultipleActiveResultSets=False;
                                       Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                customers = connection.Query<CustomerAnalyticSystem.DAL.DTOs.CustomerDTO>(query).ToList();
            }
            foreach (var c in customers)
            {
                Console.WriteLine(c);
            }
        }
        static void Main(string[] args)
        {
            //List<CustomerAnalyticSystem.DAL.DTOs.ProductDTO> products;
            //string query = "EXEC GetAllProduct";
            //string connectionString = @"Data Source=DESKTOP-16PSAEB;Initial Catalog=CreateAnalyticSystem;Integrated Security=True;Persist Security Info=False;
            //                           Pooling=False;MultipleActiveResultSets=False;
            //                           Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //   products = connection.Query<CustomerAnalyticSystem.DAL.DTOs.ProductDTO>(query).ToList();
            //}
            //foreach (var p in products)
            //{
            //    Console.WriteLine((CustomerAnalyticSystem.DAL.DTOs.ProductDTO)p);
            //}

            FillCustomerDTO();

        }
    }
}
