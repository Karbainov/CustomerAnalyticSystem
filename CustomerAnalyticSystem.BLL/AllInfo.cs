using CustomerAnalyticSystem.BLL.Analytics.ProductInfoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.BLL
{
    public class AllInfo
    {

        private static AllInfo Instance;
        private StackModel Tables { get; set; }
        public GeneralStatistics GeneralInfo { get; set; }
        public AllProductsAnalytic ProductInfo { get; set; }
        public AllCustomersPreferences CustomersInfo { get; set; }
        private AllInfo()
        { }

        public static AllInfo GetInstance()
        {
            if (Instance == null)
            {
                Instance = new AllInfo();
            }
            return Instance;
        }
        
    }
}
