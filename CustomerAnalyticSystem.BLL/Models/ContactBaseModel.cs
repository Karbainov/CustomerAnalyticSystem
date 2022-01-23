using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.BLL.Models
{
    public class ContactBaseModel
    {
        public int CustomerId { get; set; }
        public int ContactTypeId { get; set; }
        public string Value { get; set; }
    }
}
