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
    public class MapperWork
    {
        public OrderInfoByOrderIdModel MapOrderInfoByOrderId (AllOrderInfoByOrderId dto)
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AllOrderInfoByOrderId, OrderInfoByOrderIdModel>();
                cfg.CreateMap<CheckDTO, CheckBaseModel>().
                ForMember(dest => dest.Mark, act => act.MapFrom(src => src.Mark)).
                ForMember(dest => dest.Amount, act => act.MapFrom(src => src.Amount)).ForMember(dest => dest.ProductId, act => act.MapFrom(src => src.ProductId));
            });
            Mapper mapper = new(configuration);
            return mapper.Map<AllOrderInfoByOrderId, OrderInfoByOrderIdModel>(dto);
            
        }
    }
}
//CreateMap<Models.Project.Project, Dal.Repository.Project_Master>().
//    ForMember(dest => dest.Project_Locations, opt => opt.MapFrom(src => src.ProjectLocation));

            //MapperConfiguration listHelp = new MapperConfiguration(
            //    cnfg => cnfg.CreateMap<List<CheckBaseModel>, AllOrderInfoByOrderId>().ForMember(dest=>dest.Items, opt=>opt.MapFrom(
            //        src=>mapper.Map<List<CheckBaseModel>, List<CheckDTO>>(src)))
            //    );