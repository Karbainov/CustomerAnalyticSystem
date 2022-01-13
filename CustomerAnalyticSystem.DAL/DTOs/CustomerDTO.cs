using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TypeId { get; set; }

        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName} {TypeId}";
        }
    }
}
