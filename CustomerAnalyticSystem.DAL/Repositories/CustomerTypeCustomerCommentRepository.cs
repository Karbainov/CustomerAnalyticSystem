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
    public class CustomerTypeCustomerCommentRepository
    {
        public List<CustomerTypeDTO> GetAllCustomerType()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                return connection.Query<CustomerTypeDTO>(Queries.GetAllCustomerType
                    ,commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public CustomerTypeDTO GetCustomerTypeById(int id)
        {
            CustomerTypeDTO type = new CustomerTypeDTO();
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                type = connection.QuerySingle<CustomerTypeDTO>(Queries.GetCustomerTypeById
                    , new { id }
                    , commandType: CommandType.StoredProcedure);
            }
            return type;
        }

        public CustomerDTO GetCustomerById(int id)
        {
            CustomerDTO customer = new CustomerDTO();

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                customer = connection.QuerySingle<CustomerDTO>(Queries.GetCustomerById
                    , new { id }
                    , commandType: CommandType.StoredProcedure);
            }
            return customer;
        }

        public void UpdateCustomerTypeById(int id, string name)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.Query(Queries.UpdateCustomerTypeById
                    , new { id,name}
                    ,commandType: CommandType.StoredProcedure);
            }
        }

            

        public void AddCustomer(string firstName, string lastName, int typeId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.Query(Queries.AddCustomer
                    , new { lastName, firstName, typeId }
                    , commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateCustomerById(int id, string firstName, string lastName, int typeId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.Query(Queries.UpdateCustomerById
                    , new { id, firstName, lastName, typeId }
                    , commandType: CommandType.StoredProcedure);
            }
        }
        
        public void DeleteCustomerById(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.Query(Queries.DeleteCustomerById
                    ,new { id }
                    ,commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteCustomerTypeById(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.Query(Queries.DeleteCustomerTypeById
                    ,new { id }
                    ,commandType: CommandType.StoredProcedure);
            }
        }

        public void AddCustomerType(string name)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.Query(Queries.AddCustomerType
                    ,new { name }
                    ,commandType: CommandType.StoredProcedure);
            }
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

        public List<TagMarksDTO> GetAllMarksOfTagByCustomerId(int id)
        {
            List<TagMarksDTO> tagMarksDTOs = new List<TagMarksDTO>();
            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                tagMarksDTOs = connection.Query<TagMarksDTO>(Queries.GetAllTagsWithMarksByCustomerId, new { id }, commandType: CommandType.StoredProcedure).ToList();
            }
            return tagMarksDTOs;
        }

        public List<CustomerPreferenceDTO> GetAllPreferencesByCustomerId(int id)
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