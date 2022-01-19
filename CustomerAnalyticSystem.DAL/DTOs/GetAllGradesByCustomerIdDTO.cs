using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs
{
   public class GetAllGradesByCustomerIdDTO
    {   
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string GradeId { get; set; }
        public string ProductGrade { get; set; }

    }
}
