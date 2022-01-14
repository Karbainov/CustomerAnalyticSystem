using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs
{
    class OrderDTO
    {
        int Id { get; set; }
        int CustomerId { get; set; }
        string Date { get; set; }
        string StatusId { get; set; }
        int Cost { get; set; }
    }
}
