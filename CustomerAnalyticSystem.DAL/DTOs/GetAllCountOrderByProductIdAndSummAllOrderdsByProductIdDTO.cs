using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs
{
    public class GetAllCountOrderByProductIdAndSummAllOrderdsByProductIdDTO
    {
        public int ProductId { get; set; }
        public int CountOrder { get; set; }
        public int SummAllProductsInOrders { get; set; }
    }
}
