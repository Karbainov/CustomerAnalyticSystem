using CustomerAnalyticSystem.DAL.DTOs;
using System.Collections.Generic;

namespace CustomerAnalyticSystem.DAL.RepInterfaces
{
    public interface ICustomerRepository
    {
        public List<CustomerTypeDTO> GetAllCustomerType();
        public List<CustomerInfoDTO> GetAllCustomerInfoDTO();
        public CustomerDTO GetCustomerById(int id);
        public CustomerTypeDTO GetCustomerTypeById(int id);
        public CustomerInfoDTO GetCustomerByIdWithCustomerType(int id);
        public List<CommentDTO> GetAllCommentByCustomerId(int id);
        public List<ContactWithContactTypeNameDTO> GetAllContactByCustomerId(int id);
    }
}