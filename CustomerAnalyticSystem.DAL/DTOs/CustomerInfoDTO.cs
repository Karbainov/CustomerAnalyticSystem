using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs
{
    public class CustomerInfoDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TypeId { get; set; }

        public List<CommentDTO> Comments { get; set; }

        public List<ContactDTO> Contacts;

        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName} {TypeId}";
        }
    }
}
