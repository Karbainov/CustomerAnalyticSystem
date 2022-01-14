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
            int i = 0;

            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Query<AllProductInfoById, AllOrderInfoByOrderId,CheckDTO, AllProductInfoById>(Querys.GetAllOrderInfoByOrderId,
                    (productInfo, order, item) =>
                    {
                        if (concreteProduct == null)
                        {
                            concreteProduct = productInfo;
                            concreteProduct.CheckForCurrentProduct = new();
                            concreteProduct.CheckForCurrentProduct[i].Items = new();
                        }
                        else if (concreteProduct != null)
                        {
                            concreteProduct.CheckForCurrentProduct[i].Items = new();
                        }
                        concreteProduct.CheckForCurrentProduct.Add(order);
                        concreteProduct.CheckForCurrentProduct[i].Items.Add(item);
                        i++;
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
