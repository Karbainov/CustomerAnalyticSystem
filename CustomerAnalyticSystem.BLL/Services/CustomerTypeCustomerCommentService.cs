using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.DAL;
using CustomerAnalyticSystem.DAL.DTOs;

namespace CustomerAnalyticSystem.BLL
{
    public class CustomerTypeCustomerCommentService
    {
        public CustomerModel GetCustomerModel(int id)
        {
            CustomerTypeCustomerCommentRepository rep = new CustomerTypeCustomerCommentRepository();
            var DTO = rep.GetCustomerInfoService(id);
            var map = new MrMappi();
            CustomerModel result = map.MapCustomerInfoDTOToCustomerModel(DTO);

            return result;
        }

        public void UpdateCustomer(int id, string firstName, string lastName, int TypeId = 1)
        {
            CustomerTypeCustomerCommentRepository rep = new CustomerTypeCustomerCommentRepository();
            rep.UpdateCustomerById(id, firstName, lastName, TypeId);
        }

        public AllGradesByCustomerIdModel GetAllGradesByCustomerId(int id)
        {
            CustomerTypeCustomerCommentRepository rep = new CustomerTypeCustomerCommentRepository();
            var dto = rep.GetAllGradesByCustomerId(id);
            var map = new MrMappi();
            AllGradesByCustomerIdModel result = map.MapFromGetAllGradesByCustomerIdDTOToAllGradesByCustomerIdModel(dto);
            return result;
        }
    }
}
