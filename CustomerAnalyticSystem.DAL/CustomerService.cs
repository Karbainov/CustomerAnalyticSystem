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
                customers = connection.Query<CustomerDTO>(Queries.GetAllCustomer).ToList();
            }
            return customers;
        }


        public CustomerInfoDTO GetCustomerInfoService(int id)
        {
            CustomerInfoDTO customer = new();

            //List<ContactDTO> contacts = null;

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                customer = connection.QuerySingle<CustomerInfoDTO>(Queries.GetCustomerByIdWithCustomerType, new { id }
                , commandType: CommandType.StoredProcedure);
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                customer.Comments = connection.Query<CommentDTO>(Queries.GetAllCommentByCustomerId, new { id }
                , commandType: CommandType.StoredProcedure).ToList();
            }

            //using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            //{
            //    customer.Contacts = connection.Query<ContactDTO>(Querys.GetAllContactByCustomerId,
            //        param: id).ToList();
            //}

            return customer;
        }

        public List<TagMarksDTO> GetAllTagsWithMarksByCustomerId(int id)
        {
            List<TagMarksDTO> tagMarksDTOs = new List<TagMarksDTO>();
            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                tagMarksDTOs = connection.Query<TagMarksDTO>(Queries.GetAllTagsWithMarksByCustomerId, new { id }, commandType: CommandType.StoredProcedure).ToList();
            }
            return tagMarksDTOs;
        }

        public List<CustomerPreferenceDTO> GetAllPreferencesByCustomerId (int id)
        {
            List<CustomerPreferenceDTO> customerPreferenceDTOs = new List<CustomerPreferenceDTO>();
            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                customerPreferenceDTOs = connection.Query<CustomerPreferenceDTO>(Queries.GetAllPreferencesByCustomerId, new { id }, 
                    commandType: CommandType.StoredProcedure).ToList();
            }
            return customerPreferenceDTOs;
        }
    }
}