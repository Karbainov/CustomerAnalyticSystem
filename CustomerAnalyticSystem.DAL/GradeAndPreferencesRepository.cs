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
    public class GradeAndPreferencesRepository
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
        public GradeDTO GetGradeById(int id)
        {
            GradeDTO grade;

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                grade = connection.QuerySingle<GradeDTO>(Queries.GetGradeById, new { id }
               , commandType: CommandType.StoredProcedure);
            }
            return grade;
        }

        public void AddGrade(int ProductId, int CustomerId, string Value)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.QuerySingle<GradeDTO>(Queries.AddGrade, new { ProductId, CustomerId, Value }
                ,commandType: CommandType.StoredProcedure);
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
                connection.Query<GradeDTO>(Queries.UpdateGradeById, new { id, Value }
                , commandType: CommandType.StoredProcedure);
            }
        }


        public List<PreferencesDTO> GetAllPreferences()
        {
            List<PreferencesDTO> preferences = new List<PreferencesDTO>();

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                preferences = connection.Query<PreferencesDTO>(Queries.GetAllPreferences).ToList();
            }
            return preferences;
        }

        public PreferencesDTO GetPreferenceById(int id)
        {
            PreferencesDTO preference;

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                preference = connection.QuerySingle<PreferencesDTO>(Queries.GetPreferenceById, new { id }
               , commandType: CommandType.StoredProcedure);
            }
            return preference;
        }

        public void AddPreference(int ProductId, int CustomerId , int TagId, int GroupId , bool IsInterested)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.QuerySingle<PreferencesDTO>(Queries.AddPreference, new { ProductId, CustomerId, TagId, GroupId, IsInterested }
                , commandType: CommandType.StoredProcedure);
            }
        }

        public void DeletePreferenceById(int id)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.QuerySingle(Queries.DeletePreferenceById, new { id }
                , commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdatePreferenceById(int Id, bool IsInterested)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.QuerySingle<PreferencesDTO>(Queries.UpdatePreferenceById, new { Id, IsInterested }
                , commandType: CommandType.StoredProcedure);
            }
        }
    }
}
