using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.BLL.Models;

namespace CustomerAnalyticSystem.BLL.Analytics
{
    public class ProductWithCustomerPreferences: ProductBaseModel
    {
        public int ProductId { get; set; }
        public List<CustomerModel> Customers { get; set; }
    }
}
