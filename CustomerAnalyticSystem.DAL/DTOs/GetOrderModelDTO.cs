using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs
{
    public class GetOrderModelDTO
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int CustomerId { get; set; }
        public string Status { get; set; }
        public string Cost { get; set; }
    }
}
