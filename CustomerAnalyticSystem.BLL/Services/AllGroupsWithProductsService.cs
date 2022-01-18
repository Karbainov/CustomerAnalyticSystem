using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.DAL;

namespace CustomerAnalyticSystem.BLL.Services
{
    public class AllGroupsWithProductsService
    {
        public List<GroupsWithProductsModel> GetAllGroupsWithProducts()
        {
            MrMappi map = new();
            var service = new ProductTagGroupRepository();
            var dto = service.GetAllGroupsWithProducts();
            List<GroupsWithProductsModel> result = map.MapGroupsWithProducts(dto);
            return result;
        }
    }
}
