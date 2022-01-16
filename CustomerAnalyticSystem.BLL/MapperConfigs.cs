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
        public MapperConfiguration TestConfig()
        {
            MapperConfiguration configuration = new MapperConfiguration(
                cnfg => cnfg.CreateMap<CustomerInfoDTO, CustomerModel>());

            return configuration;
        }
    }
}
