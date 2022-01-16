using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.DAL.DTOs;

namespace CustomerAnalyticSystem.BLL.Models
{
    public class OrderInfoByOrderIdModel
    {
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public List<CheckBaseModel> Items { get; set; }
    }
}
