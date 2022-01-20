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
    public class GradePreferencesService
    {
        public List<GradesByProductIdModel> GetAllGradesByProductId(int id)
        {
            MrMappi map = new();
            var service = new ProductTagGroupRepository();
            var dto = service.GetAllGradesByProductId(id);
            List<GradesByProductIdModel> result = map.MapGroupsWithProducts(dto);
            return result;
        }
    }
}
