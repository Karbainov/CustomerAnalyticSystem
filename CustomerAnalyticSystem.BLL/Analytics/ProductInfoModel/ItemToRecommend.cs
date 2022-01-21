using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.BLL.Analytics.ProductInfoModel
{
    public class ItemToRecommend
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Percent { get; set; }
        public int AverageMark { get; set; }
    }
}
