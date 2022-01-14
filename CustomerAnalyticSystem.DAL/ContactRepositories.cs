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
    class ContactRepositories
    {
        public List <ContactDTO> GetAllContact()
        {
            List<ContactDTO> contactDTOs = new List<ContactDTO>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                contactDTOs = connection.Query<ContactDTO>(Querys.GetAllContact, commandType: CommandType.StoredProcedure).ToList();
            }
            return contactDTOs;
        }

        public ContactDTO GetContactById(int id)
        {
            ContactDTO contactDTO;
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                contactDTO = connection.QuerySingle<ContactDTO>(Querys.GetContactById, new { id },
                commandType: CommandType.StoredProcedure);
            }
                return contactDTO;
            
        }

        public void AddContact(int CustomerId, int ContactTypeId, string Value)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.QuerySingle<ContactDTO>(Querys.AddContact, new {CustomerId, ContactTypeId, Value},
                commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteContact(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.QuerySingle<ContactDTO>(Querys.DeleteContact, new { id},
                commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateContact (int id, int CustomerId, int ContactTypeId, string Value)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.QuerySingle<ContactDTO>(Querys.UpdateContact, new { id, CustomerId, ContactTypeId, Value },
                commandType: CommandType.StoredProcedure);
            }
        }

        public List<ContactTypeDTO> GetAllContactType()
        {
            List<ContactTypeDTO> contactDTOs = new List<ContactTypeDTO>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                contactDTOs = connection.Query<ContactTypeDTO>(Querys.GetAllContactType, commandType: CommandType.StoredProcedure).ToList();
            }
            return contactDTOs;
        }

        public ContactTypeDTO GetContactTypeById(int id)
        {
            ContactTypeDTO contactTypeDTO;
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                contactTypeDTO = connection.QuerySingle<ContactTypeDTO>(Querys.GetContactTypeById, new { id }, commandType: CommandType.StoredProcedure);
            }
            return contactTypeDTO;
        }

        public void AddContactType(string Name)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.QuerySingle<ContactTypeDTO>(Querys.AddContactType, new { Name}, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteContactType(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.QuerySingle<ContactTypeDTO>(Querys.DeleteContactType, new {id}, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateContactType(int id, string Name)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.QuerySingle<ContactTypeDTO>(Querys.UpdateContactType, new {id, Name}, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
