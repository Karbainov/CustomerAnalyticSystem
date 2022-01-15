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


namespace CustomerAnalyticSystem.DAL.DTOs
{
    class ProductRepositories
    {
        public List<ProductBaseDTO> GetAllProductsByTag(int id)
        {
            List<ProductBaseDTO> productDTOs = new List<ProductBaseDTO>();
            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                productDTOs = connection.Query<ProductBaseDTO>(Queries.GetAllProductsByTag, new { id }, commandType: CommandType.StoredProcedure).ToList();
            }
            return productDTOs;
        }

    }
}
