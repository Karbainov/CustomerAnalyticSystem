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

            List<CustomerTypeDTO> customers = rep.GetAllCustomerType();

            rep.DeleteCustomerTypeById(3);

            List<CustomerTypeDTO> customers2 = rep.GetAllCustomerType();
        }
    }
}