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
    internal class GradePreferencesRepository
    {
        public List<GradeDTO> GetAllGrades()
        {
            List<GradeDTO> grades = new List<GradeDTO>();

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                grades = connection.Query<GradeDTO>(Queries.GetAllGrades).ToList();
            }
            return grades;
        }
        //public GradeDTO GetGradesById(int id)
        //{
        //    GradeDTO grade;

        //    using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
        //    {
        //        grade = connection.QuerySingle<GradeDTO>(Queries.GetAllGradeById, new { id }
        //       , commandType: CommandType.StoredProcedure);
        //    }
        //    return grade;
        //}

        public void AddGrade(int ProductId, int CustomerId, string Value)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.QuerySingle<GradeDTO>(Queries.AddGrade, new { ProductId, CustomerId, Value }
                , commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteGradeById(int id)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.QuerySingle(Queries.DeleteGradeById, new { id }
                , commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateGradeById(int id, string Value)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.QuerySingle<GradeDTO>(Queries.UpdateGradeById, new { id, Value }
                , commandType: CommandType.StoredProcedure);
            }
        }
        public List<CustomersWithPreferenceByProductIdDTO> GetCustomersWithPreferenceByProductId(int id)
        {
            List<CustomersWithPreferenceByProductIdDTO> customersWithPreferenceByProductIdDTOs = new List<CustomersWithPreferenceByProductIdDTO>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                customersWithPreferenceByProductIdDTOs = connection.Query<CustomersWithPreferenceByProductIdDTO>(Queries.GetCustomersWithPreferenceByProductId,
                    new { id }, commandType: CommandType.StoredProcedure).ToList();
            }
            return customersWithPreferenceByProductIdDTOs;
        }
    }
}
