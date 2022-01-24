using AutoMapper;
using CustomerAnalyticSystem.BLL.Analytics.ProductInfoModel;
using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.DAL.DTOs;

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

            //completed


            int r = 0;
            //worked on
            //должно лежать в блл говне

            //должно лежать в блл говне


            AllCustomersPreferences test = new(stat);//жрет на вход генерал статистик после метода мейкстатистик           
            AllProductsAnalytic we = new(test);
            
            //test.FillBaseCustomerInfo();
            //test.AvgMarkForEveryProduct();
            //test.FindAllBestsellers();
            //foreach(var c in test.Customers)
            //{
            //    c.Value.AvgMarkForEveryProduct();
            //    c.Value.GetAllCurrentCustomerOrders();
            //}
            for (int d = 0; d < 10; d++) { }
            //AllPreferencesAndGradeInfoByCustomerIdDTO qwe = new();
            //GradePreferencesRepository www = new();
            //qwe = www.Logic(1);
            //qwe.SortToProductGroupTag();
        }
    }
}