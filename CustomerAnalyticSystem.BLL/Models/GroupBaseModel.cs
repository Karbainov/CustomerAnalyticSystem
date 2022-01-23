using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.BLL.Models
{
    public class GroupBaseModel
    {
        public int Id { get; set;}
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Description}";
        }

        public override bool Equals(object obj)
        {
            if (obj is not ProductBaseModel)
            {
                return false;
            }

            ProductBaseModel model = (ProductBaseModel)obj;

            return
                model.Id == Id
                && model.Name == Name
                && model.Description == Description;
        }
    }

}

