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

namespace CustomerAnalyticSystem.DAL
{
    public class ProductTagGroupRepository
    {
        public void AddTag (string name)
        {
            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Query(Queries.AddTag, new { name }, commandType: CommandType.StoredProcedure);
            }

        }

        public void DeleteTagById (int id)
        {
            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Query(Queries.DeleteTagById, new { id }, commandType: CommandType.StoredProcedure);
            }
        }

        public List<TagDTO> GetAllTags ()
        {
            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               return connection.Query<TagDTO>(Queries.GetAllTags, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public TagDTO GetTagById(int id)
        {
            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                return connection.QuerySingle<TagDTO>(Queries.GetTagById, new { id }, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateTagById(int id, string name)
        {
            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Query(Queries.UpdateTagById, new { id, name }, commandType: CommandType.StoredProcedure);
            }
        }
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

        public AllProductInfoById FillAllProductById(int id)
        {
            AllProductInfoById concreteProduct = null;

            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Query<AllProductInfoById, CheckWithCustomerInfoDTO, AllProductInfoById>(Queries.GetAllProductInfoById,
                    (productInfo, check) =>
                    {
                        if (concreteProduct == null)
                        {
                            concreteProduct = productInfo;
                            concreteProduct.CheckForCurrentProduct = new();
                        }
                        concreteProduct.CheckForCurrentProduct.Add(check);
                        return concreteProduct;
                    }
                , new { Id = id }
                , commandType: CommandType.StoredProcedure
                , splitOn: "Id");
            }
            return concreteProduct;

        }
    }
}
