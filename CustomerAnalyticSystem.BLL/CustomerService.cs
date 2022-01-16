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
            var DTO = rep.GetCustomerInfoService(id);
            var map = new MyMapper();
            CustomerModel result = map.MapCustomerInfoDTOToCustomerModel(DTO);

            return result;
        }
    }
}
