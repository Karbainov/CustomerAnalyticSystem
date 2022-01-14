using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs
{
    class ContactDTO
    {
        int Id { get; set; }
        int CustomerId { get; set; }
        int ContactTypeId { get; set; }
        string Value { get; set; }

    }
}
