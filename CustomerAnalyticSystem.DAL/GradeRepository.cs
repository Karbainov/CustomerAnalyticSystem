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
        public GradeDTO GetGradesById(int id)
        {
            GradeDTO grade;

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                grade = connection.QuerySingle<GradeDTO>(Querys.GetAllGradeById, new { id }
               , commandType: CommandType.StoredProcedure);
            }
            return grade;
        }

        public void AddGrade(int ProductId, int CustomerId, string Value)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.QuerySingle<GradeDTO>(Querys.AddGrade, new { ProductId, CustomerId, Value }
                ,commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteGradeById(int id)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.QuerySingle(Querys.DeleteGradeById, new { id }
                , commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateGradeById(int id, string Value)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.QuerySingle<GradeDTO>(Querys.UpdateGradeById, new { id, Value }
                , commandType: CommandType.StoredProcedure);
            }
        }
    }
}
