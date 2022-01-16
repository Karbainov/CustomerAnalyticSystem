﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CustomerAnalyticSystem.DAL.DTOs;
using CustomerAnalyticSystem.BLL.Models;

namespace CustomerAnalyticSystem.BLL
{
    public class MapperConfigs
    {

        public MapperConfiguration configForCustomer = new MapperConfiguration(
                cnfg => cnfg.CreateMap<CustomerInfoDTO, CustomerModel>());

        public MapperConfiguration configForCustomersContact = new MapperConfiguration(
            cnfg => cnfg.CreateMap<ContactDTO, ContactModel>());

        public MapperConfiguration SuperCustomerConfig = new MapperConfiguration(
            conf =>
            {
                conf.CreateMap<CustomerInfoDTO, CustomerModel>();
                conf.CreateMap<ContactWithContactTypeNameDTO, ContactModel>()
                .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                .ForMember(dest => dest.Value, act => act.MapFrom(src => src.Value));
            }
            );
    }
}