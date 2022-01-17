using CustomerAnalyticSystem.DAL.DTOs;
using System;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.DAL;

namespace CustomerAnalyticSystem.DAL
{
    public class ProductTagGroupRepository
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

        public void AddProduct_Tag (int productId, int tagId)
        {
            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Query(Queries.AddProduct_Tag, new { productId, tagId }, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteProduct_TagById (int id)
        {
            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Query(Queries.DeleteProduct_Tag, new { id }, commandType: CommandType.StoredProcedure);
            }
        }

        public List <Product_TagDTO> GetAllProduct_Tag ()
        {
            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                return connection.Query<Product_TagDTO>(Queries.GetAllProduct_Tag, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public Product_TagDTO GetProduct_TagById (int id)
        {
            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                return connection.QuerySingle<Product_TagDTO>(Queries.GetProduct_TagById, new { id }, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateProduct_TagById (int id, int productId, int tagId)
        {
            string connectionString = ConnectionString.Connection;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Query(Queries.UpdateProduct_TagById, new { id, productId, tagId }, commandType: CommandType.StoredProcedure);
            }
        }

    }
}
