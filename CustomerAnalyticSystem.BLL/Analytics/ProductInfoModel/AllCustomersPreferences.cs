using AutoMapper;
using CustomerAnalyticSystem.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAnalyticSystem.BLL.Analytics.ProductInfoModel
{
    public class AllCustomersPreferences
    {
        public Dictionary<int, ConcreteCustomer> Customers { get; set; }
        public List<CustomerInfoModel> BaseCustomers { get; set; }
        public GeneralStatistics InfoToAnalise { get; set; }

        public MapperConfiguration configuration { get; set; } = new(cfg =>
          {
              cfg.CreateMap<CustomerInfoModel, ConcreteCustomer>();
          });
        public AllCustomersPreferences(GeneralStatistics stat, List<CustomerInfoModel> custs)
        {
            InfoToAnalise = stat;
            Customers = new();
            BaseCustomers = custs;
        }
        public void FillBaseCustomerInfo()//запускается первым делом чтобы не обосраться
        {
            foreach(var customer in BaseCustomers)
            {
                ConcreteCustomer cust = new Mapper(configuration).Map<CustomerInfoModel, ConcreteCustomer>(customer);
                cust.AllOneProductMarks = new();
                Customers.Add(cust.Id,cust);
            }
        }
        public void AvgMarkForEveryProduct()
        {
            foreach (var grade in InfoToAnalise.Info.Grades)
            {
                if (Customers[grade.CustomerId].AllOneProductMarks.ContainsKey(grade.ProductId) == false)
                {
                    Customers[grade.CustomerId].AllOneProductMarks.Add(grade.ProductId, new());
                }
                Customers[grade.CustomerId].AllOneProductMarks[grade.ProductId].Add(grade.Value);
            }
        }
    }
}