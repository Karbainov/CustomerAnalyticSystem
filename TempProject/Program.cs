using CustomerAnalyticSystem.DAL.DTOs;
using CustomerAnalyticSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.BLL.Services;

namespace TempProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerTypeCustomerCommentRepository rep = new CustomerTypeCustomerCommentRepository();

            //foreach (CustomerDTO cust in c)
            //{
            //    Console.WriteLine(cust);
            //}
            //CustomerService temp = new();
            //CustomerInfoDTO qqq = 
            //temp.GetCustomerInfoService(1);
            //List<AllOrderInfoByOrderId> products;
            //string query = "EXEC GetAllOrderInfoByOrderId 1";
            //string connectionString = @"Data Source=DESKTOP-16PSAEB;Initial Catalog=CreateAnalyticSystem;Integrated Security=True;Persist Security Info=False; Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //   products = connection.Query<AllOrderInfoByOrderId>(query).ToList();
            //}
            //foreach (var p in (List<AllOrderInfoByOrderId>)products)
            //{
            //    Console.WriteLine((AllOrderInfoByOrderId)p);
            //}
            List<GetNumberOfTagsInOrderByCustomerIdDTO> kekis = new();
            ProductTagGroupRepository test = new();
            kekis = test.GetNumberOfTagsInOrderByCustomerId(1);
            //List<CustomerAnalyticSystem.DAL.DTOs.ProductDTO> products;
            //string query = "EXEC GetAllProduct";
            //string connectionString = ConnectionString.Connection;
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //   products = connection.Query<CustomerAnalyticSystem.DAL.DTOs.ProductDTO>(query).ToList();
            //}
            //foreach (var p in products)
            //{
            //    Console.WriteLine((ProductDTO)p);
            //}


            //OrderInfoByOrderIdModel keks = new();
            //OrderInfoByOrderIdService test = new();
            //keks = test.GetOrderInfoByOrderId(1);

            //List<GroupsWithProductsModel> keks1 = new();
            //AllGroupsWithProductsService test1 = new();
            //keks1 = test1.GetAllGroupsWithProducts();

            List<OrderBaseModel> keks = new();
            OrderCheckStatusService test = new();
            keks = test.GetBaseOrderModel();
        }
    }
}