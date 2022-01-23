using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.DAL;
using CustomerAnalyticSystem.DAL.DTOs;
using System.Collections.Generic;

namespace CustomerAnalyticSystem.BLL
{
    public class CustomerService
    {
        public void AddCustomer(CustomerModel model)
        {
            CustomerTypeCustomerCommentRepository rep = new CustomerTypeCustomerCommentRepository();
            MrMappi map = new MrMappi();
            CustomerDTO customer = map.MapFromCustomerModelToCustomerDTO(model);
            rep.AddCustomer(customer);
        }

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

        public void DeleteCustomerById(int id)
        {
            CustomerTypeCustomerCommentRepository rep = new CustomerTypeCustomerCommentRepository();
            rep.DeleteCustomerById(id);
        }

        public void AddCommentByCustomerId(int customerId, CommentModel model)
        {
            CustomerTypeCustomerCommentRepository rep = new CustomerTypeCustomerCommentRepository();
            rep.AddComment(customerId, model.Text);
        }

        public void DeleteCommentById(int id)
        {
            CustomerTypeCustomerCommentRepository rep = new CustomerTypeCustomerCommentRepository();
            rep.DeleteComment(id);
        }

        public List<CommentModel> GetAllCommentByCustomerId(int id)
        {
            CustomerTypeCustomerCommentRepository rep = new CustomerTypeCustomerCommentRepository();
            List<CommentDTO> coments = rep.GetAllCommentByCustomerId(id);
            var map = new MrMappi();
            return map.MapFromCommentDTOToCommentModel(coments);
        }
    }
}
