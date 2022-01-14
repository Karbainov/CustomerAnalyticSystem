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
        public List<ProductDTO> GetAllProductsByTag(int id)
        {
            List<ProductDTO> productDTOs = new List<ProductDTO>();
            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                productDTOs = connection.Query<ProductDTO>(Querys.GetAllProductsByTag, new { id }, commandType: CommandType.StoredProcedure).ToList();
            }
            return productDTOs;
        }

    }
}
