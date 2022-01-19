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

        public List<CustomerDTO> GetAllCustomers()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                return connection.Query<CustomerDTO>(Queries.GetAllCustomers
                    , commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public CustomerDTO GetCustomerById(int id)
        {
            CustomerDTO customer = null;

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.Query<CustomerDTO, object, CustomerDTO>(Queries.GetCustomerById
                    , (customer1, hz) =>
                     {
                         if (customer == null)
                         {
                             customer = customer1;
                         }
                         return customer;
                     }
                    , new { id }
                    , commandType: CommandType.StoredProcedure
                    , splitOn: "TI");
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

        public CustomerInfoDTO GetCustomerByIdWithCustomerType(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                return connection.QuerySingle<CustomerInfoDTO>(Queries.GetCustomerByIdWithCustomerType, new { id }
                , commandType: CommandType.StoredProcedure);
            }
        }

        public List<CommentDTO> GetAllCommentByCustomerId(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                return connection.Query<CommentDTO>(Queries.GetAllCommentByCustomerId, new { id }
                , commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public List<ContactWithContactTypeNameDTO> GetAllContactByCustomerId(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                return connection.Query<ContactWithContactTypeNameDTO>(Queries.GetAllContactByCustomerId,
                    new { id }
                    ,commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public CustomerInfoDTO GetCustomerInfoService(int id)
        {
            CustomerInfoDTO customer = new();

            customer = GetCustomerByIdWithCustomerType(id);
            customer.Comments = GetAllCommentByCustomerId(id);
            customer.Contacts = GetAllContactByCustomerId(id);

            return customer;
        }

        // починить SRP?        !!!!!
        public List<CustomerInfoDTO> GetAllCustomerInfoDTO()
        {
            List<CustomerInfoDTO> customers = new List<CustomerInfoDTO>();
            int tempId = 0;
            int curCustomer = -1;

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.Query<CustomerInfoDTO, ContactWithContactTypeNameDTO, CustomerInfoDTO>(
                    Queries.GetAllCustomerWithContactAndContactType
                    ,(customerInfo, contact) =>
                    {
                        if (tempId != customerInfo.Id)
                        {
                            customers.Add(customerInfo);
                            curCustomer++;
                            customers[curCustomer].Contacts = new List<ContactWithContactTypeNameDTO>();
                            customers[curCustomer].Comments = new List<CommentDTO>();
                            tempId = customerInfo.Id;
                        }

                        customers[curCustomer].Contacts.Add(contact);
                        return customers[curCustomer];
                    }
                    , splitOn: "Id"
                    , commandType: CommandType.StoredProcedure);
            }

            int curCustomerId = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.Query<CommentDTO, object, CommentDTO>(
                    Queries.GetAllComment
                    , (comment, obj) =>
                     {
                         foreach (CustomerInfoDTO cust in customers)
                         {
                             if(comment.CustomerId == cust.Id)
                             {
                                 cust.Comments.Add(comment);
                             }
                         }

                         return comment;
                     }
                     , splitOn: "TempId"
                    , commandType: CommandType.StoredProcedure);
            }

                return customers;
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