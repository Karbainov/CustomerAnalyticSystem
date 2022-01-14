using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL
{
    public class Querys
    {
        public const string GetAllCustomer = "GetAllCustomer";
        public const string GetCustomerById = "GetCustomerById";
        public const string GetAllCommentByCustomerId = "GetAllCommentByCustomerId";
        public const string GetAllContactByCustomerId = "GetAllContactByCustomerId";
        public const string GetCustomerByIdWithCustomerType = "GetCustomerByIdWithCustomerType";
        public const string GetAllOrderInfoByOrderId = "GetAllOrderInfoByOrderId";
        public const string GetAllTagsWithMarksByCustomerId = "GetAllTagsWithMarksByCustomerId";
        public const string GetCustomersWithPreferenceByProductId = "GetCustomersWithPreferenceByProductId";
        public const string GetAllPreferencesByCustomerId = "GetAllPreferencesByCustomerId";
        public const string GetContactById = "GetContactById";
        public const string GetAllContact = "GetAllContact";
        public const string AddContact = "AddContact";
        public const string DeleteContact = "DeleteContact";
        public const string UpdateContact = "UpdateContact";
        public const string GetContactTypeById = "GetContactTypeById";
        public const string GetAllContactType = "GetAllContactType";
        public const string AddContactType = "AddContactType";
        public const string DeleteContactType = "DeleteContactType";
        public const string UpdateContactType = "UpdateContactType";
        public const string GetAllProductsByTag = "GetAllProductsByTag";


    }
}
