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
using CustomerAnalyticSystem.DAL.DTOs;

namespace CustomerAnalyticSystem.DAL
{
    public class ProductTagGroupRepository
    {
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

        public List<GroupsWithProductsDTO> GetAllGroupsWithProducts()
        {
            int count = 0;
            string groupName = null;
            List<GroupsWithProductsDTO> allGroupsWithProducts = null;
            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Query<GroupsWithProductsDTO, ProductBaseDTO, GroupsWithProductsDTO>(Queries.GetAllGroupsWithProduct,
                    (group, product) =>
                    {
                        if (allGroupsWithProducts == null)
                        {
                            allGroupsWithProducts = new();
                            allGroupsWithProducts.Add(group);
                            allGroupsWithProducts[count].Products = new();
                            groupName = group.Name;
                        }
                        if (groupName != group.Name)
                        {
                            allGroupsWithProducts.Add(group);
                            groupName = group.Name;
                            count++;
                            allGroupsWithProducts[count].Products = new();
                        }
                        allGroupsWithProducts[count].Products.Add(product);
                        return allGroupsWithProducts[count];
                    }
                    , splitOn: "Id"
                    , commandType: CommandType.StoredProcedure);
            }
                return allGroupsWithProducts;
        }
    }
}
