using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.DAL
{
    public class Querys
    {
        public const string GetAllCustomer = "EXEC GetAllCustomer";
        public const string GetCustomerById = "GetCustomerById";
        public const string GetAllCommentByCustomerId = "GetAllCommentByCustomerId";
        public const string GetAllContactByCustomerId = "EXEC GetAllContactByCustomerId";
        public const string GetCustomerByIdWithCustomerType = "GetCustomerByIdWithCustomerType";
        public const string GetAllOrderInfoByOrderId = "GetAllOrderInfoByOrderId";
        public const string GetAllTagsWithMarksByCustomerId = "GetAllTagsWithMarksByCustomerId";
        
        public const string GetAllGrades = "GetAllGrades";
        public const string GetGradeById = "GetGradeById";
        public const string AddGrade = "AddGrade";
        public const string DeleteGradeById = "DeleteGradeById";
        public const string UpdateGradeById = "UpdateGradeById";

        public const string GetAllPreferences = "GetAllPreferences";
        public const string GetPreferenceById = "GetPreferenceById";
        public const string AddPreference = "AddPreference";
        public const string DeletePreferenceById = "DeletePreferenceById";
        public const string UpdatePreferenceById = "UpdatePreferenceById";
        
        public const string GetAllOrders = "GetAllOrders";
        public const string GetOrderById = "GetOrderById";
        
    }
}
