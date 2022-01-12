using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs
{
    public class AllOrderInfoByOrderId
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Amount { get; set; }
        public int Mark { get; set; }

        public override string ToString()
        {
            string s = "";
            s = s + " " + Id + " " + ProductId + " " + OrderId + " " + Amount + " " + Mark;
            return s;
        }
    }
}
