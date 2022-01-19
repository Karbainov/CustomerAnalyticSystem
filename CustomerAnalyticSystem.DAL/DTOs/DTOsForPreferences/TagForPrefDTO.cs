using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs.DTOsForPreferences
{
    public class TagForPrefDTO : AbstractPreferenceDTO
    {
        public override int Id { get ; set; }
        public override string Name { get; set; }
    }
}
