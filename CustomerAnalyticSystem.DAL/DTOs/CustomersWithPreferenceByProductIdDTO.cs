using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs
{
    class CustomersWithPreferenceByProductIdDTO
    {
        public List<CustomerDTO> customers { get; set; }
        public List<PreferencesDTO> preferences { get; set; }
       
    }
}
