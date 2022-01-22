using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs.DTOsForPreferences.ForProduct
{
    public class StackDTO
    {
        public List<ProductBaseDTO> Products { get; set; }
        public List<TagDTO> Tags { get; set; }
        public List<GroupBaseDTO> Groups { get; set; }


        public List<Product_TagDTO> Product_Tag { get; set; }


        public List<OrderDTO> Orders { get; set; }
        public List<CheckDTO> Checks { get; set; }

        public List<GradeDTO> Grades { get; set; }
    }
}
