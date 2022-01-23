using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.DAL;
using System.Collections.Generic;

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
