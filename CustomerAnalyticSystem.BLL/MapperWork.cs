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
            MapperConfiguration configuration = new MapperConfiguration(
                cnfg => cnfg.CreateMap<AllOrderInfoByOrderId, OrderInfoByOrderIdModel>()
                );
            Mapper mapper = new(configuration);
            return mapper.Map<AllOrderInfoByOrderId, OrderInfoByOrderIdModel>(dto);
        }
    }
}
