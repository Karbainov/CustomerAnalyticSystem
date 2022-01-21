﻿using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.DAL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using System.Threading.Tasks;
using CustomerAnalyticSystem.BLL.Analytics;
using CustomerAnalyticSystem.BLL.Configs;
using CustomerAnalyticSystem.DAL.DTOs.DTOsForPreferences.ForProduct;
using CustomerAnalyticSystem.DAL.DTOs.DTOsForPreferences;
using CustomerAnalyticSystem.BLL.Analytics.ProductInfoModel;

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

        public List<CustomerInfoModel> MapListCustomerDTOToListCustomerModel(List<CustomerInfoDTO> list)
        {
            var config = new MapperConfigs();
            return new Mapper(config.ConfFromCustomerInfoDTOToCustomerinfoModel).Map<List<CustomerInfoDTO>, List<CustomerInfoModel>>(list);
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
            PreferencesByCustomerIdModel result = new Mapper(config.ConfigCustomerPreferencesAndGrades)
                .Map<AllPreferencesAndGradeInfoByCustomerIdDTO,PreferencesByCustomerIdModel>(dto);
            return result;
        }
        public StackModel GetAllInfoForProductAnalise (StackDTO dto)
        {
            var config = new MapperConfigs();
            StackModel result = new Mapper(config.ConfigStack).Map<StackDTO, StackModel>(dto);
            return result;
        }
    }

    }
