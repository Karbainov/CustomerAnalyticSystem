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
        public CustomerInfoModel GetCustomerModel(int id)
        {
            CustomerTypeCustomerCommentRepository rep = new CustomerTypeCustomerCommentRepository();
            var DTO = rep.GetCustomerInfoService(id);
            var map = new MrMappi();
            CustomerInfoModel result = map.MapCustomerInfoDTOToCustomerModel(DTO);

            return result;
        }

        public List<CustomerInfoModel> GetAllCustomerInfoModels()
        {
            CustomerTypeCustomerCommentRepository rep = new CustomerTypeCustomerCommentRepository();
            List<CustomerInfoDTO> customers = rep.GetAllCustomerInfoDTO();
            var map = new MrMappi();

            return map.MapListCustomerDTOToListCustomerModel(customers);
        }

        public void UpdateCustomer(CustomerInfoModel customer)
        {
            CustomerTypeCustomerCommentRepository rep = new CustomerTypeCustomerCommentRepository();
            rep.UpdateCustomerById(customer.Id, customer.FirstName, customer.LastName, customer.TypeId);
        }
    }
}
