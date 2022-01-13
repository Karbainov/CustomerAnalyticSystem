using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs
{
    public class CommentDTO
    {
        int Id { get; set; }
        int CustomerId { get; set; }
        string Text { get; set; }
    }
}
