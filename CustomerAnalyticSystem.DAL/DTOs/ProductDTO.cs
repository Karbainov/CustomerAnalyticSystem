using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int GroupId { get; set; }


        public override string ToString()
        {
            string s = "";
            s += Id + " " + Name + " " + Description + " " + GroupId;
            return s;
        }
    }
    
}