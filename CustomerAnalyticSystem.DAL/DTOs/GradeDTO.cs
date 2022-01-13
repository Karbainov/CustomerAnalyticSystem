using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs
{
    class GradeDTO
    {
        int Id { get; set; }
        int ProductId { get; set; }
        int CustumerId { get; set; }
        string Value { get; set; }

        
    }
}
