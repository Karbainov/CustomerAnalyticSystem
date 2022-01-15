﻿using CustomerAnalyticSystem.DAL.DTOs;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL
{
    public class StatusRepository
    {
        public List<StatusDTO> GetAllStatus()
        {
            List<StatusDTO> status = new List<StatusDTO>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                status = connection.Query<StatusDTO>(Querys.GetAllStatus).ToList();
            }
            return status;
        }

        public StatusDTO GetStatusById(int id)
        {
            StatusDTO status;
            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                status = connection.QuerySingle<StatusDTO>(Querys.GetStatusById, new { id }
               , commandType: CommandType.StoredProcedure);
            }
            return status;
        }

        public void AddStatus(string Name)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.Query<StatusDTO>(Querys.AddStatus, new { Name }
                , commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteStatusById(int id)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.Query<StatusDTO>(Querys.DeleteStatusById, new { id }
                , commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateStatusById(int id, string Name)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString.Connection))
            {
                connection.Query<StatusDTO>(Querys.UpdateStatusById, new { id, Name}
                , commandType: CommandType.StoredProcedure);
            }
        }
    }
}
