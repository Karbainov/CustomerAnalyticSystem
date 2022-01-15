using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs
{
    public class AllOrderInfoByOrderId
    {
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public List<CheckWithProductAndGroupInfoDTO> Items { get; set; }
    }
}
