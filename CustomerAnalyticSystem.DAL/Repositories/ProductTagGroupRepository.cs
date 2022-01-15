using CustomerAnalyticSystem.DAL.DTOs;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace CustomerAnalyticSystem.DAL
{
    public class ProductTagGroupRepository
    {
        public void AddTag (string name)
        {
            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Query(Queries.AddTag, new { name }, commandType: CommandType.StoredProcedure);
            }

        }

        public void DeleteTagById (int id)
        {
            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Query(Queries.DeleteTagById, new { id }, commandType: CommandType.StoredProcedure);
            }
        }

        public List<TagDTO> GetAllTags ()
        {
            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               return connection.Query<TagDTO>(Queries.GetAllTags, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public TagDTO GetTagById (int id)
        {
            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                return connection.QuerySingle(Queries.GetTagById, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateTagById (int id, string name)
        {
            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Query(Queries.UpdateTagById, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
