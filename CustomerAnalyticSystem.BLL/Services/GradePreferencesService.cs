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
        public List<PreferencesBaseModel> GetBasePreferencesModel()
        {
            MrMappi map = new();
            var service = new GradePreferencesRepository();
            var dto = service.GetAllPreferences();
            List<PreferencesBaseModel> result = map.MapFromPreferencesDTOToPreferenceBaseModel(dto);
            return result;
        }
    }
}
