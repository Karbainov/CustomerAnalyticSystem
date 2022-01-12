using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs
{
    internal class CustomerInfoDTO
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int TypeId { get; set; }

        List<CommentDTO> Comments;

        List<ContactsDTO> Contacts;
    }
}
