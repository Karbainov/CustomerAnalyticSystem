using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using CustomerAnalyticSystem.DAL;
using CustomerAnalyticSystem.DAL.DTOs;
using System.Data;

namespace CustomerAnalyticSystem.DAL
{
    public class GradeRepository
    {
        public List<GradeDTO> GetAllGrades()
        {
            List<GradeDTO> grades = new List<GradeDTO>();

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                grades = connection.Query<GradeDTO>(Querys.GetAllGrades).ToList();
            }
            return grades;
        }
    }
}
