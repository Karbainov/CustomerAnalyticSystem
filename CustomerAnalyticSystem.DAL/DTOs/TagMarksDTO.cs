using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs
{
    //DEVKZN-14
    public class TagMarksDTO
    {
        public int Id { get; set; }
        public int TagId { get; set; }
        public string Name { get; set; }
        public int Mark { get; set; }
    }
}
