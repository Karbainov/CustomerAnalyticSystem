using CustomerAnalyticSystem.DAL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.BLL.Models
{
    public class CheckBaseModel
    {
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public int Mark { get; set; }
    }
}
