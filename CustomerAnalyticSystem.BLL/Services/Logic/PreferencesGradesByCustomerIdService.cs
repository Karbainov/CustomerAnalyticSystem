using CustomerAnalyticSystem.DAL;

namespace CustomerAnalyticSystem.BLL.Services.Logic
{
    public class PreferencesGradesByCustomerIdService
    {
        public PreferencesByCustomerIdModel GetCustomerPreferences(int id)
        {
            MrMappi map = new();
            var service = new GradePreferencesRepository();
            var dto = service.GetAllCustomerPreferencesAndGrades(id).SortToProductGroupTag();
            PreferencesByCustomerIdModel result = map.MapFromPreferences(dto);
            return result;
        }
    }
}
