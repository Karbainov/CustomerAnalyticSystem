using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs
{
    public class CheckDTO
    {
		public int Id { get; set; }
		public int ProductId { get; set; }
		public int OrderId { get; set; }
		public int Amount { get; set; }
		public int Mark { get; set; }
	}
}
