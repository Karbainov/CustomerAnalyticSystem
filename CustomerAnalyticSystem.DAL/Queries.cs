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

        public const string AddProduct_Tag = "AddProduct_Tag";
        public const string DeleteProduct_Tag = "DeleteProduct_TagById";
        public const string GetAllProduct_Tag = "GetAllProduct_Tag";
        public const string GetProduct_TagById = "GetProduct_TagById";
        public const string UpdateProduct_TagById = "UpdateProduct_TagById";

        public const string AddTag = "AddTag";
        public const string DeleteTagById = "DeleteTagById";
        public const string GetAllTags = "GetAllTags";
        public const string GetTagById = "GetTagById";
        public const string UpdateTagById = "UpdateTagById";
    }
}
