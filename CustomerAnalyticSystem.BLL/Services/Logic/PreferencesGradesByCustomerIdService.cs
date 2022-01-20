using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using System.Threading.Tasks;
using CustomerAnalyticSystem.DAL;

namespace CustomerAnalyticSystem.BLL.Services.Logic
{
    public class PreferencesGradesByCustomerIdService
    {
        public PreferencesByCustomerIdModel GetCustomerPreferences(int id)
        {
            MrMappi map = new();
            var service = new GradePreferencesRepository();
            var dto = service.Logic(id).SortToProductGroupTag();
            PreferencesByCustomerIdModel result = map.MapFromPreferences(dto);
                return result;
        }
    }
}
