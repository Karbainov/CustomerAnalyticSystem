using System;
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
        public MapperConfiguration ConfFromCustomerInfoDTOToCustomerModel = new MapperConfiguration(
            conf =>
            {
                conf.CreateMap<CustomerInfoDTO, CustomerModel>();
                conf.CreateMap<ContactWithContactTypeNameDTO, ContactModel>()
                .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                .ForMember(dest => dest.Value, act => act.MapFrom(src => src.Value));
                conf.CreateMap<CommentDTO, CommentModel>()
                .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.Text, act => act.MapFrom(src => src.Text));
            }
            );
    }
}