using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.DAL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using System.Threading.Tasks;
using CustomerAnalyticSystem.BLL.Configs;

namespace CustomerAnalyticSystem.BLL
{
    public class MrMappi
    {
        public OrderInfoByOrderIdModel MapOrderInfoByOrderId(AllOrderInfoByOrderId dto)
        {
            var config = new MapperConfigs();
            return new Mapper(config.configOrderInfo).Map<AllOrderInfoByOrderId, OrderInfoByOrderIdModel>(dto);
        }
        
        public List<GroupsWithProductsModel> MapGroupsWithProducts (List<GroupsWithProductsDTO> dto)
        {
            var config = new MapperConfigs();
            return new Mapper(config.ConfigAllGroupsWithProducts).Map<List<GroupsWithProductsDTO>, List<GroupsWithProductsModel>>(dto);
        }
        public CustomerInfoModel MapCustomerInfoDTOToCustomerModel(CustomerInfoDTO DTO)
        {
            var mapConfig = new MapperConfigs();
            return new Mapper(mapConfig.ConfFromCustomerInfoDTOToCustomerModel).Map<CustomerInfoDTO, CustomerInfoModel>(DTO);
        }

        public List<CustomerModel> MapListCustomerDTOToListCustomerModel(List<CustomerDTO> list)
        {
            var config = new MapperConfigs();
            return new Mapper(config.ConfFromCustomerDTOToCustomerModel).Map<List<CustomerDTO>, List<CustomerModel>>(list);
        }
    
    }
}
