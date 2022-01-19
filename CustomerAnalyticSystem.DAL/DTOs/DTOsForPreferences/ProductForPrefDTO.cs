using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL.DTOs.DTOsForPreferences
{
    public class ProductForPrefDTO : AbstractPreferenceDTO, IDescription
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public string Description { get; set; }
    }
}
