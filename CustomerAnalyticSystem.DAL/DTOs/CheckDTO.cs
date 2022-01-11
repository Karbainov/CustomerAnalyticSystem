using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs
{
    internal class CheckDTO
    {
        int Id { get; set; }
        int ProductId { get; set; }
        int OrderId { get; set; }
        int Amount { get; set; }
        int Mark { get; set; }
    }
}
