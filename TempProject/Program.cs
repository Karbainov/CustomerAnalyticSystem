using CustomerAnalyticSystem.DAL.DTOs;
using CustomerAnalyticSystem.DAL;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.BLL.Services;
using CustomerAnalyticSystem.DAL.DTOs.DTOsForPreferences;
using CustomerAnalyticSystem.BLL.Analytics;
using CustomerAnalyticSystem.BLL;
using CustomerAnalyticSystem.BLL.Services.Logic;
using CustomerAnalyticSystem.BLL.Analytics.ProductInfoModel;
using AutoMapper;

namespace TempProject
{
    public class Program
    {
        static void Main(string[] args)
        {

            MapperConfiguration config = new MapperConfiguration(
            conf =>
            {
                conf.CreateMap<CustomerDTO, CustomerInfoModel>();
            });

            //PreferencesByCustomerIdModel kekis;

            //PreferencesGradesByCustomerIdService test = new();
            //kekis = test.GetCustomerPreferences(1);
            //kekis.ClearPrevGrades();

            //PreferredProductsForOneCustomer cucus = new(kekis);
            GeneralStatistics stat = new();
            stat.MakeStatistics();

            //completed
   

            int r = 0;
            //worked on
            //должно лежать в блл говне
            List<CustomerInfoModel> Custs = new();
            CustomerTypeCustomerCommentService w = new();
            List<CustomerDTO> we = w.GetAllCustomers();
            Custs = new Mapper(config).Map<List<CustomerDTO>, List<CustomerInfoModel>>(we);
            //должно лежать в блл говне


            AllCustomersPreferences test = new(stat, Custs);
            test.FillBaseCustomerInfo();
            test.AvgMarkForEveryProduct();
            foreach(var c in test.Customers)
            {
                c.Value.AvgMarkForEveryProduct();
            }
            //AllPreferencesAndGradeInfoByCustomerIdDTO qwe = new();
            //GradePreferencesRepository www = new();
            //qwe = www.Logic(1);
            //qwe.SortToProductGroupTag();
        }
    }
}