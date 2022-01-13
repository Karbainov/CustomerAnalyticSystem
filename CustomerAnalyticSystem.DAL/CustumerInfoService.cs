using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.DAL.DTOs;
using Dapper;
using Microsoft.Data.SqlClient;


namespace CustomerAnalyticSystem.DAL
{
    public class CustumerInfoService
    {
        public List <TagMarksDTO> GetAllMarksOfTagByCustomerId (int id)
        {
            List<TagMarksDTO> tagMarksDTOs = new List<TagMarksDTO>();
            string query = "GetAllTagsWithMarksByCustomerId";
            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                tagMarksDTOs = connection.Query<TagMarksDTO>(query, param:id).ToList() ;
            }
            return tagMarksDTOs;
        }
    }
}
