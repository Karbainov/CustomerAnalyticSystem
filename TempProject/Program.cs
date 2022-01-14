using System;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using CustomerAnalyticSystem.DAL.DTOs;
using CustomerAnalyticSystem.DAL;



namespace TempProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerTypeCustomerCommentRepository rep = new CustomerTypeCustomerCommentRepository();

            List<CustomerDTO> cust = rep.GetAllCustomer();

            rep.DeleteCustomerById(3);

            List<CustomerDTO> cust2 = rep.GetAllCustomer();

        }
    }
}