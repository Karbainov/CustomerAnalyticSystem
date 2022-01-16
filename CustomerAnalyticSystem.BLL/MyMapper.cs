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
            return new Mapper(mapConfig.TestConfig()).Map<CustomerInfoDTO, CustomerModel>(DTO);
        }
    }
}
