﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.DAL.Interfaces;
namespace CustomerAnalyticSystem.DAL.DTOs
{
    public class ProductRepository : IBaseProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int GroupId { get; set; }
        public List<CheckDTO> CheckForCurrentProduct { get; set; }
    }
}
