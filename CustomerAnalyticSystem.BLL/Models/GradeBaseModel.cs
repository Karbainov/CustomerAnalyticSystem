using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.BLL.Models
{
    public class GradeBaseModel
    {
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int Grade { get; set; }
        public bool IsInterested = false;
    }
}
