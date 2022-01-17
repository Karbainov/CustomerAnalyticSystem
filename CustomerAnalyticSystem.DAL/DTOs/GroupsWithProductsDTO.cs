using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs
{
    public class GroupsWithProductsDTO: GroupBaseDTO
    {
        public List<ProductBaseDTO> Products { get; set; }
    }
}
