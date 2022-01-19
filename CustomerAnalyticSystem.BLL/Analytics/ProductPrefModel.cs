using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.BLL.Analytics;

namespace CustomerAnalyticSystem.BLL.Analytics
{
    public class ProductPrefModel : PreferencesBaseAbstractModel
    {
        public override int Id { get; set; }
        public override bool IsInterested { get; set; }
        public override string Name { get; set; }

        public string Description { get; set; }
    }
}
