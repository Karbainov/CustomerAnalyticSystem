﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs
{
    class PreferenceDTO
    {
		public int Id { get; set; }
		public int ProductId { get; set; }
		public int CustumerId { get; set; }
		public int TagId { get; set; }
		public int GroupId { get; set; }
		public bool IsInterested { get; set; }

	}
}
