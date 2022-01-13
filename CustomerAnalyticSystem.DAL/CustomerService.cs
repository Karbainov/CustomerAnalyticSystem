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
            CustomerInfoDTO customer = null;

            CustomerDTO customerDTO = null;
            List<CommentDTO> comments = null;
            List<ContactDTO> contacts = null;

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                comments = connection.Query<CommentDTO>(Querys.GetAllCommentByCustomerId,
                    param: id).ToList();
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                contacts = connection.Query<ContactDTO>(Querys.GetAllContactByCustomerId,
                    param: id).ToList();
            }
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                customerDTO = connection.QuerySingle<CustomerDTO>(Querys.GetCustomerById,
                    param: id);
            }

            customer.Id = customerDTO.Id;
            customer.FirstName = customerDTO.FirstName;
            customer.LastName = customerDTO.LastName;
            customer.TypeId = customerDTO.TypeId;

            customer.Comments = comments;
            customer.Contacts = contacts;

            return customer;
        }
    }
}