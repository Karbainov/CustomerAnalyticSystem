using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.DAL;
using CustomerAnalyticSystem.DAL.DTOs.DTOsForPreferences.ForProduct;
using CustomerAnalyticSystem.DAL.DTOs.DTOsForPreferences;
using CustomerAnalyticSystem.BLL.Analytics.ProductInfoModel;
using CustomerAnalyticSystem.DAL.RepInterfaces;

namespace CustomerAnalyticSystem.BLL.Services
{
    public class ProductTagGroupService
    {
        protected IProductTagGroupRepository _rep = new ProductTagGroupRepository();

        public ProductTagGroupService(IProductTagGroupRepository rep = null)
        {
            if (rep is not null)
            {
                _rep = rep;
            }
        }

        #region tag crud
        public List<TagModel> GetAllTags()
        {
            MrMappi map = new();
            var dto = _rep.GetAllTags();
            List<TagModel> result = map.MapFromTagDTOToTagModel(dto);
            return result;
        }

        public void UpdateTagById(int id, string name)
        {
            MrMappi map = new();
            _rep.UpdateTagById(id, name);
        }

        public void DeleteTagById(int id)
        {
            MrMappi map = new();
            _rep.DeleteTagById(id);
        }

        public void AddTag(string name)
        {
            MrMappi map = new();
            _rep.AddTag(name);
        }       

        #endregion

        #region product crud
        public void UpdateProductById(int id, string name, string description, int groupId)
        {
            MrMappi map = new();
            _rep.UpdateProductById(id, name, description, groupId);
        }

        public void AddProduct(string name, string description, int groupId)
        {
            MrMappi map = new();
            _rep.AddProduct(name, description, groupId);
        }

        public List<ProductBaseModel> GetAllProducts()
        {
            MrMappi map = new();
            var dto = _rep.GetAllProductsWithGroups();
            var result = map.MapFromProductBaseDTOToProductBaseModel(dto);
            return result;
        }

        public void DeleteProductById(int id)
        {
            MrMappi map = new();
            _rep.DeleteProductById(id);
        }

        #endregion     

        #region group crud
        public List<GroupBaseModel> GetAllGroups()
        {
            MrMappi map = new();
            var dto = _rep.GetAllGroup();
            List<GroupBaseModel> result = map.MapFromGroupBaseDTOToGroupBaseModel(dto);
            return result;
        }

        public void UpdateGroupById(int id, string name, string description)
        {
            MrMappi map = new();
            _rep.UpdateGroupById(id, name, description);
        }

        public void AddGroup(string name, string description)
        {
            MrMappi map = new();
            _rep.AddGroup(name, description);
        }

        public void DeleteGroupById(int id)
        {
            MrMappi map = new();
            _rep.DeleteGroupById(id);
        }

        #endregion

        #region product tag crud

        public void UpdateProductTag(int id, int productId, int tagId)
        {
            MrMappi map = new();
            _rep.UpdateProduct_TagById(id, productId, tagId);
        }

        public void AddProductTag(int productId, int tagId)
        {
            MrMappi map = new();
            _rep.AddProduct_Tag(productId, tagId);
        }

        public void DeleteProductTag(int id)
        {
            MrMappi map = new();
            _rep.DeleteProduct_TagById(id);
        }

        #endregion

        public List<ProductBaseModel> GetAllProductsByTagId(int id)
        {
            MrMappi map = new();
            var dto = _rep.GetAllProductsByTag(id);
            var result = map.MapFromProductBaseDTOToProductBaseModel(dto);
            return result;
        }

        public List<ProductBaseModel> GetAllProductsByGroupId(int id)
        {
            MrMappi map = new();
            var dto = _rep.GetAllProductsByGroupId(id);
            var result = map.MapFromProductBaseDTOToProductBaseModel(dto);
            return result;
        }

        public List<TagModel> GetAllTagsByProductId(int id)
        {
            MrMappi map = new();
            var dto = _rep.GetAllTagsByProductId(id);
            List<TagModel> result = map.MapFromTagDTOToTagModel(dto);
            return result;
        }

        public void DeleteProduct_TagByTagIdAndProductId(int idP, int idT)
        {
            MrMappi map = new();
            _rep.DeleteProduct_TagByTagIdAndProductId(idP, idT);
        }

        public List<GroupsWithProductsModel> GetAllGroupsWithProducts()
        {
            MrMappi map = new();
            var dto = _rep.GetAllGroupsWithProducts();
            List<GroupsWithProductsModel> result = map.MapGroupsWithProducts(dto);
            return result;
        }

        public StackModel GetAllInfoAboutAll ()
        {
            MrMappi map = new();
            var dto = _rep.GetAllInfo();
            StackModel result = map.GetAllInfoForProductAnalise(dto);
            return result;
        }
    }
}
