using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.BLL.Models
{
    public class GradesByProductIdModel
    {
        public int Id { get; set; }
        public List<GradeBaseModel> Value { get; set; }
    }
}
