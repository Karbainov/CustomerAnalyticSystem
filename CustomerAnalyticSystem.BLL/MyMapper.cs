using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.DAL.DTOs;
using AutoMapper;

namespace CustomerAnalyticSystem.BLL
{
    internal class MyMapper
    {
        public CustomerModel MapCustomerInfoDTOToCustomerModel(CustomerInfoDTO DTO)
        {
            var mapConfig = new MapperConfigs();
            return new Mapper(mapConfig.SuperCustomerConfig).Map<CustomerInfoDTO, CustomerModel>(DTO);
        }

        public ContactModel MapContacDTOToContactModel(ContactDTO DTO)
        {
            var config = new MapperConfigs();
            return new Mapper(config.configForCustomersContact).Map<ContactDTO, ContactModel>(DTO);
        }
    }
}
