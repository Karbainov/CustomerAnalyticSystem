﻿using CustomerAnalyticSystem.DAL.DTOs;
using System;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.DAL;
using System.Data;
using CustomerAnalyticSystem.DAL.DTOs;
using CustomerAnalyticSystem.DAL.DTOs.DTOsForPreferences;
namespace CustomerAnalyticSystem.DAL
{
    public class GradePreferencesRepository
    {
        public List<GradeDTO> GetAllGrades()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                return connection.Query<GradeDTO>(Queries.GetAllGrades).ToList();
            }
        }
        public GradeDTO GetGradeById(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                return connection.QuerySingle<GradeDTO>(Queries.GetGradeById, new { id }
               , commandType: CommandType.StoredProcedure);
            }
        }

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
                connection.Query<GradeDTO>(Queries.UpdateGradeById, new { id, Value }
                , commandType: CommandType.StoredProcedure);
            }
        }

        public List<PreferencesDTO> GetAllPreferences()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                return connection.Query<PreferencesDTO>(Queries.GetAllPreferences).ToList();
            }
        }

        public PreferencesDTO GetPreferenceById(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                return connection.QuerySingle<PreferencesDTO>(Queries.GetPreferenceById, new { id }
               , commandType: CommandType.StoredProcedure);
            }
        }

        public void AddPreference(int ProductId, int CustomerId, int TagId, int GroupId, bool IsInterested)
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

        public List<CustomersWithPreferenceByProductIdDTO> GetCustomersWithPreferenceByProductId(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                return connection.Query<CustomersWithPreferenceByProductIdDTO>(Queries.GetCustomersWithPreferenceByProductId,
                    new { id }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public AllPreferencesInfoByCustomerIdDTO Logic (int id)
        {
            int i = 0;
            string connectionString = ConnectionString.Connection;
            AllPreferencesInfoByCustomerIdDTO customerPreferences = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Query<AllPreferencesInfoByCustomerIdDTO, ProductForPrefDTO, TagForPrefDTO
                    , GroupForPrefDTO, AllPreferencesInfoByCustomerIdDTO>("GetAllPreferencesInfoByCustomerId",
                    (customer, product, tag, group) =>
                    {
                        if (customerPreferences == null)
                        {
                            customerPreferences = customer;
                            customerPreferences.Preferences = new();
                        }
                        if (product != null)
                        {
                            customerPreferences.Preferences.Add(product);
                        }
                        else if (group != null)
                        {
                            customerPreferences.Preferences.Add(group);
                        }
                        else if (tag != null)
                        {
                            customerPreferences.Preferences.Add(tag);
                        }
                        i++;
                        return customerPreferences;
                    }
                    , new { id = id }
                    , commandType: CommandType.StoredProcedure
                    , splitOn: "Id"
                    );
            }
            return null;
        }
    }
}
