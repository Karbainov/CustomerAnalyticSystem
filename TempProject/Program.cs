using CustomerAnalyticSystem.DAL.DTOs;
using CustomerAnalyticSystem.DAL;
using System;
using System.Collections.Generic;

namespace TempProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ////CustomerService customerDapper = new CustomerService();
            ////List<CustomerDTO> c = customerDapper.GetAllCustomerService();

            ////foreach (CustomerDTO cust in c)
            ////{
            ////    Console.WriteLine(cust);
            ////}
            //CustomerService temp = new();
            //CustomerInfoDTO qqq = 
            //temp.GetCustomerInfoService(1);
            ////List<AllOrderInfoByOrderId> products;
            ////string query = "EXEC GetAllOrderInfoByOrderId 1";
            ////string connectionString = @"Data Source=DESKTOP-16PSAEB;Initial Catalog=CreateAnalyticSystem;Integrated Security=True;Persist Security Info=False; Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
            ////using (SqlConnection connection = new SqlConnection(connectionString))
            ////{
            ////   products = connection.Query<AllOrderInfoByOrderId>(query).ToList();
            ////}
            ////foreach (var p in (List<AllOrderInfoByOrderId>)products)
            ////{
            ////    Console.WriteLine((AllOrderInfoByOrderId)p);
            ////}
            //AllOrderInfoByOrderId kekis = new();
            //FillOrderInfo test = new();
            //kekis = test.FillOrderInfoByOrderId(1);
            ////List<CustomerAnalyticSystem.DAL.DTOs.ProductDTO> products;
            ////string query = "EXEC GetAllProduct";
            ////string connectionString = ConnectionString.Connection;
            ////using (SqlConnection connection = new SqlConnection(connectionString))
            ////{
            ////   products = connection.Query<CustomerAnalyticSystem.DAL.DTOs.ProductDTO>(query).ToList();
            ////}
            ////foreach (var p in products)
            ////{
            ////    Console.WriteLine((ProductDTO)p);
            ////}

            List<GradeDTO> grades = new List<GradeDTO>();
            GradeRepository Repository = new();
            grades = Repository.GetAllGrades();

        }
    }
}