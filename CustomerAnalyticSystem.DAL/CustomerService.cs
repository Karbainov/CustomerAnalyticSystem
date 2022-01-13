using CustomerAnalyticSystem.DAL.DTOs;
using System;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.DAL;
using System.Data;

namespace CustomerAnalyticSystem.DAL
{
    public class CustomerService
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


        public CustomerInfoDTO GetCustomerInfoService(int id)
        {
            CustomerInfoDTO customer = new();

            CustomerDTO customerDTO = null;
            List<CommentDTO> comments = null;
            //List<ContactDTO> contacts = null;

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                customer = connection.QuerySingle<CustomerInfoDTO>(Querys.GetCustomerById, new { id }, commandType: CommandType.StoredProcedure);
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                customer.Comments = connection.Query<CommentDTO>(Querys.GetAllCommentByCustomerId, new { id }, commandType: CommandType.StoredProcedure).ToList();
            }

            //using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            //{
            //    customer.Contacts = connection.Query<ContactDTO>(Querys.GetAllContactByCustomerId,
            //        param: id).ToList();
            //}

            //customer.Comments = comments;
            //customer.Contacts = contacts;

            return customer;
        }
    }
}