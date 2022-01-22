using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.DAL.DTOs.DTOsForPreferences;

namespace CustomerAnalyticSystem.DAL.DTOs
{
    public class AllPreferencesAndGradeInfoByCustomerIdDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }

        public List<AbstractPreferenceDTO> Preferences { get; set; }

        #region PrefList_Product_Group_Tag
        public List <ProductForPrefDTO> Products { get; set; }
        public List <GroupForPrefDTO> Groups { get; set; }
        public List <TagForPrefDTO> Tags { get; set; }
        #endregion

        #region Grades
        public List<GradeInfoByCustomerIdDTO> Grades { get; set; }
        public List <GradeInfoByCustomerIdForTagsDTO> TagGrades { get; set; }
        #endregion
        public AllPreferencesAndGradeInfoByCustomerIdDTO SortToProductGroupTag()
        {
            Groups = new();
            Tags = new();
            Products = new();
            foreach (var c in Preferences)
            {
                if (c is ProductForPrefDTO)
                {
                    Products.Add((ProductForPrefDTO)c);
                }
                else if (c is GroupForPrefDTO)
                {
                    Groups.Add((GroupForPrefDTO)c);
                }
                else if (c is TagForPrefDTO)
                {
                    Tags.Add((TagForPrefDTO)c);
                }
            }
            return this;
        }
    }

}
