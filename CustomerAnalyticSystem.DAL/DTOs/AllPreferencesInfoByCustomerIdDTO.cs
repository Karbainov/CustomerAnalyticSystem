using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.DAL.DTOs.DTOsForPreferences;

namespace CustomerAnalyticSystem.DAL.DTOs
{
    public class AllPreferencesInfoByCustomerIdDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }

        public List<AbstractPreferenceDTO> Preferences { get; set; }
    }
}
