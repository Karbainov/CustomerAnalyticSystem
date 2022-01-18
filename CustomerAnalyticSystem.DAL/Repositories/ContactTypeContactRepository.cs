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
    public class ContactTypeContactRepository
    {
        public List<ContactDTO> GetAllContact()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                return connection.Query<ContactDTO>(Queries.GetAllContact, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public ContactDTO GetContactById(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                return connection.QuerySingle<ContactDTO>(Queries.GetContactById, new { id }
                , commandType: CommandType.StoredProcedure);
            }
        }

        public void AddContact(int CustomerId, int ContactTypeId, string Value)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.QuerySingle<ContactDTO>(Queries.AddContact, new { CustomerId, ContactTypeId, Value }
                , commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteContact(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.QuerySingle<ContactDTO>(Queries.DeleteContact, new { id }
                , commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateContact(int id, int CustomerId, int ContactTypeId, string Value)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.QuerySingle<ContactDTO>(Queries.UpdateContact, new { id, CustomerId, ContactTypeId, Value },
                commandType: CommandType.StoredProcedure);
            }
        }

        public List<ContactTypeDTO> GetAllContactType()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                return connection.Query<ContactTypeDTO>(Queries.GetAllContactType
                    , commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public ContactTypeDTO GetContactTypeById(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                return connection.QuerySingle<ContactTypeDTO>(Queries.GetContactTypeById, new { id }
                , commandType: CommandType.StoredProcedure);
            }
        }

        public void AddContactType(string Name)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.QuerySingle<ContactTypeDTO>(Queries.AddContactType, new { Name }
                , commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteContactType(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.QuerySingle<ContactTypeDTO>(Queries.DeleteContactType, new { id }
                , commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateContactType(int id, string Name)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.QuerySingle<ContactTypeDTO>(Queries.UpdateContactType, new { id, Name }
                , commandType: CommandType.StoredProcedure);
            }
        }
    }
}