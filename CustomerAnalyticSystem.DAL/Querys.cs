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
        public const string GetAllGrades = "GetAllGrade";
        public const string GetAllGradesById = "GetAllGradesById";
        public const string AddGrade = "AddGrade";
        public const string DeleteGradeById = "DeleteGradeById";
        public const string UpdateGradeById = "UpdateGradeById";

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

    }
}
