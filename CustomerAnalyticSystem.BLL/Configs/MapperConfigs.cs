﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.DAL.DTOs;
using AutoMapper;

namespace CustomerAnalyticSystem.BLL.Configs
{
    public class MapperConfigs
    {

        public MapperConfiguration ConfFromCustomerInfoDTOToCustomerModel = new MapperConfiguration(
           conf =>
           {
               conf.CreateMap<CustomerInfoDTO, CustomerInfoModel>();
               conf.CreateMap<ContactWithContactTypeNameDTO, ContactModel>()
               .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
               .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
               .ForMember(dest => dest.Value, act => act.MapFrom(src => src.Value));
               conf.CreateMap<CommentDTO, CommentModel>()
               .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
               .ForMember(dest => dest.Text, act => act.MapFrom(src => src.Text));
           });

        public MapperConfiguration ConfFromCustomerDTOToCustomerModel = new MapperConfiguration(
            conf => 
            {
                conf.CreateMap<CustomerDTO, CustomerModel>();
            });

        public MapperConfiguration configOrderInfo = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<AllOrderInfoByOrderId, OrderInfoByOrderIdModel>();
            cfg.CreateMap<CheckDTO, CheckBaseModel>().
            ForMember(dest => dest.Mark, act => act.MapFrom(src => src.Mark)).
            ForMember(dest => dest.Amount, act => act.MapFrom(src => src.Amount)).ForMember(dest => dest.ProductId, act => act.MapFrom(src => src.ProductId));
        });

        public MapperConfiguration ConfigAllGroupsWithProducts = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<GroupsWithProductsDTO, GroupsWithProductsModel>();
                cfg.CreateMap<ProductBaseDTO, ProductBaseModel>().ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, act => act.MapFrom(src => src.Description));
            });

    }
}
