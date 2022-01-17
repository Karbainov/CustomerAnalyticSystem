using System;
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
            }
            );
    }
}
//CreateMap<Models.Project.Project, Dal.Repository.Project_Master>().
//    ForMember(dest => dest.Project_Locations, opt => opt.MapFrom(src => src.ProjectLocation));

            //MapperConfiguration listHelp = new MapperConfiguration(
            //    cnfg => cnfg.CreateMap<List<CheckBaseModel>, AllOrderInfoByOrderId>().ForMember(dest=>dest.Items, opt=>opt.MapFrom(
            //        src=>mapper.Map<List<CheckBaseModel>, List<CheckDTO>>(src)))
            //    );