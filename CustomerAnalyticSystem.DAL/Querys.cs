﻿using System;
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
        public const string GetAllGradeById = "GetAllGradeById";
        public const string AddGrade = "AddGrade";
        public const string DeleteGradeById = "DeleteGrade";
        public const string UpdateGradeById = "UpdateGrade";
        public const string GetAllOrders = "GetAllOrders";
        public const string GetOrderById = "GetOrderById";
        
    }
}
