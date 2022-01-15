using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL
{
    public class Queries
    {
        public const string GetAllCustomer = "GetAllCustomer";
        public const string GetCustomerById = "GetCustomerById";
        public const string AddCustomer = "AddCustomer";
        public const string UpdateCustomerById = "UpdateCustomerById";
        public const string DeleteCustomerById = "DropCustomerById";

        public const string GetAllCommentByCustomerId = "GetAllCommentByCustomerId";
        public const string GetAllContactByCustomerId = "GetAllContactByCustomerId";
        public const string GetCustomerByIdWithCustomerType = "GetCustomerByIdWithCustomerType";

        public const string GetAllOrderInfoByOrderId = "GetAllOrderInfoByOrderId";
        public const string GetAllTagsWithMarksByCustomerId = "GetAllTagsWithMarksByCustomerId";
    }
}
