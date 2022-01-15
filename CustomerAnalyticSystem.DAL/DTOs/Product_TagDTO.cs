using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs
{
    public class Product_TagDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int TagId { get; set; }
    }
}
