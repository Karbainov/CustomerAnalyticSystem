using CustomerAnalyticSystem.BLL.Analytics;
using CustomerAnalyticSystem.BLL.Models;
using System.Collections.Generic;

namespace CustomerAnalyticSystem.BLL
{
    public class PreferencesByCustomerIdModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<PreferencesBaseAbstractModel> CustomerPrefs { get; set; }


        public List<ProductPrefModel> Products { get; set; }
        public List<GroupPrefModel> Groups { get; set; }
        public List<TagPrefModel> Tags { get; set; }

        public List<GradePrefModel> CustomerGrades { get; set; }
        public List<CustomerTagGradesModel> TagGrades { get; set; }


        

        public void ClearPrevGrades()
        {
            for (int i = 0; i + 1 < CustomerGrades.Count; i++)
            {
                if (CustomerGrades[i].Id == CustomerGrades[i + 1].Id)
                {
                    CustomerGrades.Remove(CustomerGrades[i]);
                }
            }
        }
    }

}
