using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL
{
    public class Queries
    {

        // еще нет коммент, чек, груп, продукт


        #region customer
        public const string GetAllCustomers = "GetAllCustomer";
        public const string GetCustomerById = "GetCustomerById";
        public const string AddCustomer = "AddCustomer";
        public const string UpdateCustomerById = "UpdateCustomerById";
        public const string DeleteCustomerById = "DropCustomerById";
        #endregion

        #region preferences
        public const string GetAllPreferences = "GetAllPreferences";
        public const string GetPreferenceById = "GetPreferenceById";
        public const string AddPreference = "AddPreference";
        public const string DeletePreferenceById = "DeletePreferenceById";
        public const string UpdatePreferenceById = "UpdatePreferenceById";
        #endregion

        #region grades
        public const string GetAllGrades = "GetAllGrade";
        public const string GetGradeById = "GetAllGradeById";
        public const string AddGrade = "AddGrade";
        public const string DeleteGradeById = "DeleteGrade";
        public const string UpdateGradeById = "UpdateGrade";
        #endregion

        #region orders
        public const string GetAllOrders = "GetAllOrders";
        public const string GetOrderById = "GetOrderById";
        public const string AddOrder = "AddOrder";
        public const string DeleteOrderById = "DeleteOrderById";
        public const string UpdateOrderById = "UpdateOrderById";
        #endregion

        #region status
        public const string GetAllStatus = "GetAllStatus";
        public const string GetStatusById = "GetStatusById";
        public const string AddStatus = "AddStatus";
        public const string DeleteStatusById = "DeleteStatusById";
        public const string UpdateStatusById = "UpdateStatusById";
        #endregion    

        #region contact
        public const string GetContactById = "GetContactById";
        public const string GetAllContact = "GetAllContact";
        public const string AddContact = "AddContact";
        public const string DeleteContact = "DeleteContact";
        public const string UpdateContact = "UpdateContact";
        #endregion

        #region contactType
        public const string GetContactTypeById = "GetContactTypeById";
        public const string GetAllContactType = "GetAllContactType";
        public const string AddContactType = "AddContactType";
        public const string DeleteContactType = "DeleteContactType";
        public const string UpdateContactType = "UpdateContactType";
        #endregion   

        #region product_tag
        public const string AddProduct_Tag = "AddProduct_Tag";
        public const string DeleteProduct_Tag = "DeleteProduct_TagById";
        public const string GetAllProduct_Tag = "GetAllProduct_Tag";
        public const string GetProduct_TagById = "GetProduct_TagById";
        public const string UpdateProduct_TagById = "UpdateProduct_TagById";
        #endregion

        #region tag
        public const string AddTag = "AddTag";
        public const string DeleteTagById = "DeleteTagById";
        public const string GetAllTags = "GetAllTags";
        public const string GetTagById = "GetTagById";
        public const string UpdateTagById = "UpdateTagById";
        #endregion

        #region customer_type
        public const string AddCustomerType = "AddCustomerType";
        public const string GetAllCustomerType = "GetAllCustomerType";
        public const string GetCustomerTypeById = "GetCustomerTypeById";
        public const string DeleteCustomerTypeById = "DropCustomerTypeById";
        public const string UpdateCustomerTypeById = "UpdateCustomerTypeById";
        #endregion

        public const string GetAllCommentByCustomerId = "GetAllCommentByCustomerId";
        public const string GetAllContactByCustomerId = "GetAllContactByCustomerId";
        public const string GetCustomerByIdWithCustomerType = "GetCustomerByIdWithCustomerType";
        public const string GetAllOrderInfoByOrderId = "GetAllOrderInfoByOrderId";
        public const string GetAllTagsWithMarksByCustomerId = "GetAllTagsWithMarksByCustomerId";
        public const string GetCustomersWithPreferenceByProductId = "GetCustomersWithPreferenceByProductId";
        public const string GetAllPreferencesByCustomerId = "GetAllPreferencesByCustomerId";
        public const string GetAllProductsByTag = "GetAllProductsByTag";
        public const string GetAllProductInfoById = "GetAllProductInfoById";
        public const string GetAllOrdersByCustomerId = "GetAllOrdersByCustomerId";
        public const string GetAllGroupsWithProduct = "GetAllGroupsWithProducts";
        public const string GetNumberOfTagsInOrderByCustomerId = "GetNumberOfTagsInOrderByCustomerId";


    }
}
