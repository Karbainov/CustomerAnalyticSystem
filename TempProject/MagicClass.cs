using Dapper;
using Microsoft.Data.SqlClient;
using System.Linq;
namespace TempProject
{
    public class MagicCLass
    {
        public string connectionString { get; set; }
        public string StoredProcedure { get; set; }

        public MagicCLass(string connect)
        {
            connectionString = connect;
        }
        public object GetAll(string procedure)
        {
            object toReturn;
            StoredProcedure = procedure;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                toReturn = connection.Query<CustomerAnalyticSystem.DAL.DTOs.ProductBaseDTO>(StoredProcedure).ToList();
            }
            return toReturn;
        }
    }
}
