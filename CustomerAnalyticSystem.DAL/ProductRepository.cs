using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.DAL.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CustomerAnalyticSystem.DAL.DTOs
{
    public class ProductRepository
    {
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
