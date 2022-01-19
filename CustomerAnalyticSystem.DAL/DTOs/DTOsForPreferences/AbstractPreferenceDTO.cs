using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs.DTOsForPreferences
{
    public abstract class AbstractPreferenceDTO
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
    }
}
