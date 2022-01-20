using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.BLL.Analytics;
using AutoMapper;

namespace CustomerAnalyticSystem.BLL.Analytics
{
    class PreferredProductsForOneCustomer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public PreferencesByCustomerIdModel Preferences { get; set; }
        public List <GradePrefModel> TrueMarkForProduct { get; set; }
        public List <GradePrefModel> TrueMarkForTag { get; set; }
        public PreferredProductsForOneCustomer(PreferencesByCustomerIdModel preferences)
        {
            CustomerId = preferences.Id;
            FirstName = preferences.FirstName;
            LastName = preferences.LastName;
            Preferences = preferences;
            //TrueMark = new;
        }

        public void CheckProductMark ()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ProductPrefModel, GradePrefModel>();
            });
            Dictionary<int, GradePrefModel> products = new();
            foreach(var c in Preferences.CustomerGrades)
            {
                products.Add(c.Id, c);
            }
            foreach(var c in Preferences.Products)
            {
                var temp = new Mapper(config).Map<ProductPrefModel, GradePrefModel>(c);
                if (products[c.Id] is null)
                {
                    products.Add(temp.Id, temp);
                    products[temp.Id].Value = 11;
                }
                else
                {
                    products.Add(temp.Id, temp);
                }
            }
            TrueMarkForProduct = products.Values.ToList();
        }

        public void CheckForTag()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TagPrefModel, GradePrefModel>();
            });
            foreach(var c in Preferences.TagGrades)
            {

            }
            List<int> curTagMarks = new();

        }

    }
}
