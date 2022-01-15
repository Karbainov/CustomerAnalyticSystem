using System;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using CustomerAnalyticSystem.DAL.DTOs;
using CustomerAnalyticSystem.DAL;
using CustomerAnalyticSystem.DAL.DTOs;
using CustomerAnalyticSystem.DAL;


namespace TempProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTagGroupRepository xuy = new ProductTagGroupRepository();
            List<TagDTO> tags = xuy.GetAllTags();
        }
    }
}