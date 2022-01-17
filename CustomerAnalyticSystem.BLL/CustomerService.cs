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
    public class CustomerService
    {
        public CustomerModel GetCustomerModel(int id)
        {
            CustomerTypeCustomerCommentRepository rep = new CustomerTypeCustomerCommentRepository();
            CustomerInfoDTO DTO = rep.GetCustomerInfoService(id);
            MyMapper map = new MyMapper();
            CustomerModel result = map.MapCustomerInfoDTOToCustomerModel(DTO);

            return result;
        }

        public void UpdateCustomer(int id, string firstName, string lastName, int TypeId = 1)
        {
            CustomerTypeCustomerCommentRepository rep = new CustomerTypeCustomerCommentRepository();
            rep.UpdateCustomerById(id, firstName, lastName, TypeId);
        }
    }
}
