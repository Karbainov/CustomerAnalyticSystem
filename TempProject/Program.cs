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

namespace TempProject
{
    public class Program
    {
        static void Main(string[] args)
        {


            //PreferencesByCustomerIdModel kekis;

            //PreferencesGradesByCustomerIdService test = new();
            //kekis = test.GetCustomerPreferences(1);
            //kekis.ClearPrevGrades();

            //PreferredProductsForOneCustomer cucus = new(kekis);


            StackModel eww;
            ProductTagGroupService we = new();
            eww = we.GetAllInfoAboutAll();
            MrFucky lol = new(eww);
            lol.FillProducts();
            lol.FillGroups();
            lol.FillTags();
            lol.GetListOfAllTagsInProduct();
            lol.GetListOfAllGroupsInProduct();


            int r = 0;
            //AllPreferencesAndGradeInfoByCustomerIdDTO qwe = new();
            //GradePreferencesRepository www = new();
            //qwe = www.Logic(1);
            //qwe.SortToProductGroupTag();
        }
    }
}