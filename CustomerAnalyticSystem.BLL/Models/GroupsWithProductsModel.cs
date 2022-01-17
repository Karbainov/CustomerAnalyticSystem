using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.BLL.Models
{
    public class GroupsWithProductsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ProductBaseModel> Products { get; set; }
    }
}
