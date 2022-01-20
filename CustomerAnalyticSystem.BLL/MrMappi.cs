using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.DAL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using System.Threading.Tasks;
using CustomerAnalyticSystem.BLL.Analytics;
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
        public CustomerModel MapCustomerInfoDTOToCustomerModel(CustomerInfoDTO DTO)
        {
            var mapConfig = new MapperConfigs();
            return new Mapper(mapConfig.ConfFromCustomerInfoDTOToCustomerModel).Map<CustomerInfoDTO, CustomerModel>(DTO);
        }

        public List<OrderBaseModel> MapBaseOrder(List<OrderDTO> dto)
        {
            var config = new MapperConfigs();
            return new Mapper(config.ConfigAllGroupsWithProducts).Map<List<OrderDTO>,List<OrderBaseModel>>(dto);
        }

        public List<TagModel> MapFromTagDTOToTagModel(List<TagDTO> dto)
        {
            var config = new MapperConfigs();
            return new Mapper(config.ConfigBaseTag).Map<List<TagDTO>, List<TagModel>>(dto);
        }

        public List<ProductBaseModel> MapFromProductBaseDTOToProductBaseModel(List<ProductBaseDTO> dto)
        {
            var config = new MapperConfigs();
            return new Mapper(config.ConfigBaseProduct).Map<List<ProductBaseDTO>, List<ProductBaseModel>>(dto);
        }

        public PreferencesByCustomerIdModel MapFromPreferences (AllPreferencesAndGradeInfoByCustomerIdDTO dto)
        {
            var config = new MapperConfigs();
            PreferencesByCustomerIdModel qwe = new Mapper(config.ConfigCustomerPreferencesAndGrades)
                .Map<AllPreferencesAndGradeInfoByCustomerIdDTO,PreferencesByCustomerIdModel>(dto);
            return qwe;
        }
    }
}
