using System;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using CustomerAnalyticSystem.DAL;
using CustomerAnalyticSystem.DAL.DTOs;
using CustomerAnalyticSystem.DAL;

namespace TempProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerService customerDapper = new CustomerService();
            List<CustomerDTO> c = customerDapper.GetAllCustomerService();

            foreach (CustomerDTO cust in c)
            {
                Console.WriteLine(cust);
            }
        }
    }
}
