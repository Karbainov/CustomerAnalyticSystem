using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.DAL.DTOs.DTOsForPreferences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.BLL.Analytics
{
    public class GradePrefModel 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Value { get; set; }
    }
}
