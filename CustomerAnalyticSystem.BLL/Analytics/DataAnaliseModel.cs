using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.BLL.Analytics
{
    public class DataAnaliseModel
    {
        public List<PreferencesByCustomerIdModel> AllCustomers { get; set; }
        public List<ProductWithCustomerPreferences> AllProducts { get; set; }

    }
}
