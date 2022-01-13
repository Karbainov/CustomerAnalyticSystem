using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs
{
    class PreferenceDTO
    {
		int Id { get; set; }
		int ProductId { get; set; }
		int CustumerId { get; set; }
		int TagId { get; set; }
		int GroupId { get; set; }
		bool IsInterested { get; set; }

	}
}
