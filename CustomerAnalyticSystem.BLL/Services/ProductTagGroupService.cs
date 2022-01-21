using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.DAL;
using CustomerAnalyticSystem.DAL.DTOs;
using CustomerAnalyticSystem.DAL.DTOs.DTOsForPreferences.ForProduct;
using CustomerAnalyticSystem.DAL.DTOs.DTOsForPreferences;
using CustomerAnalyticSystem.BLL.Analytics.ProductInfoModel;

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
            List<ProductBaseModel> result = map.MapFromProductBaseDTOToProductBaseModel(dto);
            return result;
        }

        public StackModel GetAllInfoAboutAll ()
        {
            MrMappi map = new();
            var service = new ProductTagGroupRepository();
            var dto = service.GetAllInfo();
            StackModel result = map.GetAllInfoForProductAnalise(dto);
            return result;
        }
    }
}
