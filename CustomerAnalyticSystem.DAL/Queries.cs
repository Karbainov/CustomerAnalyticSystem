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

       
        public const string GetAllGrades = "GetAllGrade";
        public const string GetAllGradeById = "GetAllGradeById";
        public const string AddGrade = "AddGrade";
        public const string DeleteGradeById = "DeleteGrade";
        public const string UpdateGradeById = "UpdateGrade";

        public const string GetAllOrders = "GetAllOrders";
        public const string GetOrderById = "GetOrderById";
        public const string AddOrder = "AddOrder";
        public const string DeleteOrderById = "DeleteOrderById";
        public const string UpdateOrderById = "UpdateOrderById";

        public const string GetAllStatus = "GetAllStatus";
        public const string GetStatusById = "GetStatusById";
        public const string AddStatus = "AddStatus";
        public const string DeleteStatusById = "DeleteStatusById";
        public const string UpdateStatusById = "UpdateStatusById";

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

        public const string AddProduct_Tag = "AddProduct_Tag";
        public const string DeleteProduct_Tag = "DeleteProduct_Tag";
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
