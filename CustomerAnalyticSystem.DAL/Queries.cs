using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL
{
    public class Queries
    {
        public const string GetAllCustomer = "EXEC GetAllCustomer";
        public const string GetCustomerById = "GetCustomerById";
        public const string GetAllCommentByCustomerId = "GetAllCommentByCustomerId";
        public const string GetAllContactByCustomerId = "EXEC GetAllContactByCustomerId";
        public const string GetCustomerByIdWithCustomerType = "GetCustomerByIdWithCustomerType";
        public const string GetAllOrderInfoByOrderId = "GetAllOrderInfoByOrderId";
        public const string GetAllTagsWithMarksByCustomerId = "GetAllTagsWithMarksByCustomerId";

        public const string AddCustomerType = "AddCustomerType";
        public const string GetAllCustomerType = "GetAllCustomerType";
        public const string GetCustomerTypeById = "GetCustopmerTypeById";
        public const string DeleteCustomerTypeById = "DropCustomerTypeById";
        public const string UpdateCustomerTypeById = "UpdateCustomerTypeById";
    }
}
