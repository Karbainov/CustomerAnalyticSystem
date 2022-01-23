using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.BLL.Models
{
    public class ProductTagBaseModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int TagId { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is not ProductTagBaseModel)
            {
                return false;
            }

            ProductTagBaseModel model = (ProductTagBaseModel)obj;

            return
                model.Id == Id
                && model.ProductId == ProductId
                && model.TagId == TagId;
        }
    }
}
