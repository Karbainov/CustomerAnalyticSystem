using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.BLL.Models
{
    public class PreferencesBaseModel
    {
		public int Id { get; set; }
		public int ProductId { get; set; }
		public int CustomerId { get; set; }
		public int TagId { get; set; }
		public int GroupId { get; set; }
		public bool IsInterested { get; set; }
	}
}
