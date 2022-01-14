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
    class MarksAndPreferencesRepositories
    {
        public List <CustomersWithPreferenceByProductIdDTO> GetCustomersWithPreferenceByProductId (int id)
        {
            List<CustomersWithPreferenceByProductIdDTO> customersWithPreferenceByProductIdDTOs = new List<CustomersWithPreferenceByProductIdDTO>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                customersWithPreferenceByProductIdDTOs = connection.Query<CustomersWithPreferenceByProductIdDTO>(Querys.GetCustomersWithPreferenceByProductId, 
                    new { id }, commandType: CommandType.StoredProcedure).ToList();
            }
            return customersWithPreferenceByProductIdDTOs;
        }
    }
}
