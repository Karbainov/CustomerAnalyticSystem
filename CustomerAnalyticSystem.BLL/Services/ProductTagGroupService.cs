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
        public List <TagModel> GetAllTags()
        {
            MrMappi map = new();
            var service = new ProductTagGroupRepository();
            var dto = service.GetAllTags();
            List<TagModel> result = map.MapFromTagDTOToTagModel(dto);
            return result;
        }

        public List <ProductBaseModel> GetAllProductsByTagId(int id)
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

        public List<ProductBaseModel> GetAllProducts()
        {
            MrMappi map = new();
            var service = new ProductTagGroupRepository();
            var dto = service.GetAllProductsWithGroups();
            var result = map.MapFromProductBaseDTOToProductBaseModel(dto);
            return result;
        }

        public List<GroupBaseModel> GetAllGroups()
        {
            MrMappi map = new();
            var service = new ProductTagGroupRepository();
            var dto = service.GetAllGroup();
            List<GroupBaseModel> result = map.MapFromGroupBaseDTOToGroupBaseModel(dto);
            return result;
        }
    }
}
