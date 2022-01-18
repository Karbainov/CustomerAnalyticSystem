using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs
{
    public class CustomerWithTagsMarks
    {
        public int CustomerID { get; set; }
        public List<TagMarksDTO> TagMarks { get; set; }
    }
}
