using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.DAL;
using CustomerAnalyticSystem.DAL.DTOs;

namespace CustomerAnalyticSystem.BLL.Services
{
    public class ProductTagGroupService
    {

        #region tag crud
        public List<TagModel> GetAllTags()
        {
            MrMappi map = new();
            var service = new ProductTagGroupRepository();
            var dto = service.GetAllTags();
            List<TagModel> result = map.MapFromTagDTOToTagModel(dto);
            return result;
        }

        public void UpdateTagById(int id, string name)
        {
            MrMappi map = new();
            var service = new ProductTagGroupRepository();
            service.UpdateTagById(id, name);
        }

        public void DeleteTagById(int id)
        {
            MrMappi map = new();
            var service = new ProductTagGroupRepository();
            service.DeleteTagById(id);
        }

        public void AddTag(string name)
        {
            MrMappi map = new();
            var service = new ProductTagGroupRepository();
            service.AddTag(name);
        }

        //public TagModel GetTagById(int id)
        //{
        //    MrMappi map = new();
        //    var service = new ProductTagGroupRepository();
        //    var dto = service.GetTagById(id);
        //    TagModel result = map.MapFromTagDTOToTagModel(dto);
        //    return result;
        //}

        #endregion

        #region product crud
        public void UpdateProductById(int id, string name, string description, int groupId)//ProductBaseModel product)
        {
            MrMappi map = new();
            var service = new ProductTagGroupRepository();
            service.UpdateProductById(id, name, description, groupId);
        }

        public void AddProduct(string name, string description, int groupId)
        {
            MrMappi map = new();
            var service = new ProductTagGroupRepository();
            service.AddProduct(name, description, groupId);
        }

        public List<ProductBaseModel> GetAllProducts()
        {
            MrMappi map = new();
            var service = new ProductTagGroupRepository();
            var dto = service.GetAllProductsWithGroups();
            var result = map.MapFromProductBaseDTOToProductBaseModel(dto);
            return result;
        }

        public void DeleteProductById(int id)
        {
            MrMappi map = new();
            var service = new ProductTagGroupRepository();
            service.DeleteProductById(id);
        }

        //public ProductBaseDTO GetProductById(int id)
        //{
        //    MrMappi map = new();
        //    var service = new ProductTagGroupRepository();
        //    service.GetProductById(id);
        //    var result = map.MapFromProductBaseDTOToProductBaseModel(dto);
        //    return result;
        //}

        #endregion     

        #region group crud
        public List<GroupBaseModel> GetAllGroups()
        {
            MrMappi map = new();
            var service = new ProductTagGroupRepository();
            var dto = service.GetAllGroup();
            List<GroupBaseModel> result = map.MapFromGroupBaseDTOToGroupBaseModel(dto);
            return result;
        }

        public void UpdateGroupById(int id, string name, string description)
        {
            MrMappi map = new();
            var service = new ProductTagGroupRepository();
            service.UpdateGroupById(id, name, description);
        }

        public void AddGroup(string name, string description)
        {
            MrMappi map = new();
            var service = new ProductTagGroupRepository();
            service.AddGroup(name, description);
        }

        public void DeleteGroupById(int id)
        {
            MrMappi map = new();
            var service = new ProductTagGroupRepository();
            service.DeleteGroupById(id);
        }

        //public ProductBaseDTO GetGroupById(int id)
        //{
        //    MrMappi map = new();
        //    var service = new ProductTagGroupRepository();
        //    service.GeGroupById(id);
        //    var result = map.MapFromProductBaseDTOToProductBaseModel(dto);
        //    return result;
        //}

        #endregion

        #region product tag crud

        public void UpdateProductTag(int id, int productId, int tagId)
        {
            MrMappi map = new();
            var service = new ProductTagGroupRepository();
            service.UpdateProduct_TagById(id, productId, tagId);
        }

        public void AddProductTag(int productId, int tagId)
        {
            MrMappi map = new();
            var service = new ProductTagGroupRepository();
            service.AddProduct_Tag(productId, tagId);
        }

        public void DeleteProductTag(int id)
        {
            MrMappi map = new();
            var service = new ProductTagGroupRepository();
            service.DeleteProduct_TagById(id);
        }

        #endregion

        public List<ProductBaseModel> GetAllProductsByTagId(int id)
        {
            MrMappi map = new();
            var service = new ProductTagGroupRepository();
            var dto = service.GetAllProductsByTag(id);
            var result = map.MapFromProductBaseDTOToProductBaseModel(dto);
            return result;
        }

        public List<ProductBaseModel> GetAllProductsByGroupId(int id)
        {
            MrMappi map = new();
            var service = new ProductTagGroupRepository();
            var dto = service.GetAllProductsByGroupId(id);
            var result = map.MapFromProductBaseDTOToProductBaseModel(dto);
            return result;
        }

        public List<TagModel> GetAllTagsByProductId(int id)
        {
            MrMappi map = new();
            var service = new ProductTagGroupRepository();
            var dto = service.GetAllTagsByProductId(id);
            List<TagModel> result = map.MapFromTagDTOToTagModel(dto);
            return result;
        }

        public void DeleteProduct_TagByTagIdAndProductId(int idP, int idT)
        {
            MrMappi map = new();
            var service = new ProductTagGroupRepository();
            service.DeleteProduct_TagByTagIdAndProductId(idP, idT);
        }
    }
}
