using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.DAL;
using CustomerAnalyticSystem.DAL.DTOs;
using System.Collections.Generic;

namespace CustomerAnalyticSystem.BLL
{
    public class CustomerTypeCustomerCommentService
    {
        public CustomerInfoModel GetCustomerModel(int id)
        {
            CustomerTypeCustomerCommentRepository rep = new CustomerTypeCustomerCommentRepository();
            var DTO = rep.GetCustomerInfoService(id);
            var map = new MrMappi();
            CustomerInfoModel result = map.MapCustomerInfoDTOToCustomerModel(DTO);

            return result;
        }

        public List<CustomerTypeModel> GetAllCustomerTypeModel()
        {
            List<CustomerTypeModel> customerTypes = new List<CustomerTypeModel>();

            CustomerTypeCustomerCommentRepository rep = new CustomerTypeCustomerCommentRepository();
            List<CustomerTypeDTO> DTOs = rep.GetAllCustomerType();
            MrMappi map = new MrMappi();
            customerTypes = map.MapCustomerTypeDTOToCustomerTypeModel(DTOs);

            return customerTypes;
        }

        //public CustomerModel GetCustomerModel(int id)
        //{
        //    CustomerTypeCustomerCommentRepository rep = new CustomerTypeCustomerCommentRepository();
        //    CustomerInfoDTO DTO = rep.GetCustomerInfoService(id);
        //    MrMappi map = new MrMappi();
        //    CustomerModel result = map.MapCustomerInfoDTOToCustomerModel(DTO);

        public void UpdateCustomer(int id, string firstName, string lastName, int TypeId = 1)
        {
            CustomerTypeCustomerCommentRepository rep = new CustomerTypeCustomerCommentRepository();
            rep.UpdateCustomerById(id, firstName, lastName, TypeId);
        }


        public List<CustomerDTO> GetAllCustomers()
        {
            CustomerTypeCustomerCommentRepository rep = new CustomerTypeCustomerCommentRepository();
            return rep.GetAllCustomers();
        }
        //public void UpdateComment(int id, int customerId, string text)
        //{
        //    CustomerTypeCustomerCommentRepository rep = new CustomerTypeCustomerCommentRepository();
        //    rep.UpdateComment(id, customerId, text);
        //}

        //public void DeleteComment(int id)
        //{
        //    CustomerTypeCustomerCommentRepository rep = new CustomerTypeCustomerCommentRepository();
        //    rep.DeleteComment(id);
        //}

    }
}
