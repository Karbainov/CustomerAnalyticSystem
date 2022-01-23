using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.DAL.DTOs;
using CustomerAnalyticSystem.DAL.DTOs.DTOsForPreferences;
using CustomerAnalyticSystem.DAL.DTOs.DTOsForPreferences.ForProduct;

namespace CustomerAnalyticSystem.DAL.RepInterfaces
{
    public interface IProductTagGroupRepository
    {
        public List<TagDTO> GetAllTags();
        public void UpdateTagById(int id, string name);
        public void DeleteTagById(int id);
        public void AddTag(string name);

        public void UpdateProductById(int id, string name, string description, int groupId);
        public void AddProduct(string name, string description, int groupId);
        public List<ProductBaseDTO> GetAllProduct();
        public void DeleteProductById(int id);
        

        public void AddProduct_Tag(int productId, int tagId);
        public void DeleteProduct_TagById(int id);
        public List<Product_TagDTO> GetAllProduct_Tag();
        public void UpdateProduct_TagById(int id, int productId, int tagId);

        public void AddGroup(string name, string description);
        public List<GroupBaseDTO> GetAllGroup();        
        public void DeleteGroupById(int id);
        public void UpdateGroupById(int id, string name, string description);
        

        public List<CountTagsInAllOrdersDTO> GetTagPopularity();
        public List<CountProductsInAllOrdersDTO> GetProductPopularity();
        public List<GetNumberOfTagsInOrderByCustomerIdDTO> GetNumberOfTagsInOrderByCustomerId(int id);
        public StackDTO GetAllInfo();

        public List<ProductsWithGroupsDTO> GetAllProductsByGroupId(int id);
        public List<TagDTO> GetAllTagsByProductId(int id);
        public void DeleteProduct_TagByTagIdAndProductId(int idP, int idT);
        public List<ProductsWithGroupsDTO> GetAllProductsByTag(int id);
        public List<ProductsWithGroupsDTO> GetAllProductsWithGroups();
        public List<GroupsWithProductsDTO> GetAllGroupsWithProducts();























    }
}
