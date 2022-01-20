using CustomerAnalyticSystem.DAL.DTOs;
using CustomerAnalyticSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.BLL.Services;

namespace TempProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<GradeBaseModel> list = new List<GradeBaseModel>();
            GradePreferencesService serv = new GradePreferencesService();
            list = serv.GetAllGradesByProductId(1);
        }
    }
}