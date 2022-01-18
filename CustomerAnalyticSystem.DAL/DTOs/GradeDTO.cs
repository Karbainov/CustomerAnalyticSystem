using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs
{
    class GradeDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CustumerId { get; set; }
        public string Value { get; set; }
        
    }
}
