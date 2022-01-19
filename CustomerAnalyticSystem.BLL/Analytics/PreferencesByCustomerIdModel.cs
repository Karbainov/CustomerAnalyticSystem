using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.BLL.Models;

namespace CustomerAnalyticSystem.BLL
{
    public class PreferencesByCustomerIdModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        List<PreferencesBaseModel> CustomerPrefs { get; set; }
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

        public void FillPreferencesList (List<PreferencesBaseModel> preferencesByCustomerId)
        {
            int curProduct = 0;
            CustomerPrefs = new();
            foreach (var product in preferencesByCustomerId)
            {
                if (curProduct != product.ProductId)
                {
                    CustomerPrefs.Add(product);
                    curProduct = product.ProductId;
                }
            }
        }
    }

}
