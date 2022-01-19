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
        public List <TagModel> GetTag()
        {
            MrMappi map = new();
            var service = new ProductTagGroupRepository();
            var dto = service.GetAllTags();
            List<TagModel> result = map.MapFromTagDTOToTagModel(dto);
            return result;
        }
    }
}
