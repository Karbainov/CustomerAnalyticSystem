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
