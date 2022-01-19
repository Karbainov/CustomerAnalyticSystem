using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.BLL.Analytics;

namespace CustomerAnalyticSystem.BLL
{
    public class PreferencesByCustomerIdModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        List<PreferencesBaseAbstractModel> CustomerPrefs { get; set; }
        List<GradeBaseModel> CustomerGrades { get; set; }


        public PreferencesByCustomerIdModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void FillGradeList(List<GradeBaseModel> gradesByCustomerId)
        {
            int curProduct = 0;
            CustomerGrades = new();
            foreach (var product in gradesByCustomerId)
            {
                if (curProduct != product.ProductId)
                {
                    CustomerGrades.Add(product);
                    curProduct = product.ProductId;
                }
            }
        }

        public void FillPreferencesList (List<PreferencesBaseAbstractModel> preferencesByCustomerId)
        {
            CustomerPrefs = new();
            foreach (var product in preferencesByCustomerId)
            {
                CustomerPrefs.Add(product);
            }
        }
    }

}
