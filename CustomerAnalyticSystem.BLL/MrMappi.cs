﻿using CustomerAnalyticSystem.BLL.Models;
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
        public List<CommentModel> MapFromCommentDTOToCommentModel(List<CommentDTO> dto)
        {
            var config = new MapperConfigs();
            return new Mapper(config.ConfFromCommentDTOToCommentModel).Map<List<CommentDTO>, List<CommentModel>>(dto);
        }

        public OrderInfoByOrderIdModel MapOrderInfoByOrderId(AllOrderInfoByOrderId dto)
        {
            var config = new MapperConfigs();
            return new Mapper(config.configOrderInfo).Map<AllOrderInfoByOrderId, OrderInfoByOrderIdModel>(dto);
        }
        
        public List<CustomerTypeModel> MapCustomerTypeDTOToCustomerTypeModel(List<CustomerTypeDTO> dto)
        {
            var config = new MapperConfigs();
            return new Mapper(config.ConfFromCustomerTypeDTOToCustomerTypeModel).Map<List<CustomerTypeDTO>, List<CustomerTypeModel>>(dto);
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

        public List<ContactTypeModel> MapFromContactTypeDTOToContactTypeModel(List<ContactTypeDTO> dto)
        {
            var config = new MapperConfigs();
            return new Mapper(config.ConfFromContactTypeDTOToContactTypeModel)
                .Map<List<ContactTypeDTO>, List<ContactTypeModel>>(dto);
        }

        public List<ContactModel> MapFromContactWithContactTypeNameDTOToContactModel(List<ContactWithContactTypeNameDTO> dto)
        {
            var config = new MapperConfigs();
            return new Mapper(config.ConfContactWithContactTypeDTOToContactModel)
                .Map<List<ContactWithContactTypeNameDTO>, List<ContactModel>>(dto);
        }
    
    }


}
