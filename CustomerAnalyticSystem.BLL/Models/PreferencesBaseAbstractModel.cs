using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.BLL.Models
{
    public abstract class PreferencesBaseAbstractModel
    {
		public abstract int Id { get; set; }
		public abstract bool IsInterested { get; set; }
		public abstract string Name { get; set; }
	}
}
