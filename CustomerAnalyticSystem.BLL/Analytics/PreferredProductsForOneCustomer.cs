using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.BLL.Analytics;
using AutoMapper;
using System.Threading;

namespace CustomerAnalyticSystem.BLL.Analytics
{
    public class PreferredProductsForOneCustomer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public PreferencesByCustomerIdModel Preferences { get; set; }
        public List <GradePrefModel> TrueMarkForProduct { get; set; }
        public List <GradePrefModel> TrueMarkForTag { get; set; }

        // public List<TagPrefModel> Tags - ТЕГИПРЕФЫ
        // public List<CustomerTagGradesModel> TagGrades ТЕГИОЦЕНКИ

        public PreferredProductsForOneCustomer(PreferencesByCustomerIdModel preferences)
        {
            CustomerId = preferences.Id;
            FirstName = preferences.FirstName;
            LastName = preferences.LastName;
            Preferences = preferences;
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
                if (products.ContainsKey(c.Id) == true)
                {
                    products.Add(temp.Id, temp);
                    if (c.IsInterested == true)
                        temp.Value = 11;
                    else
                        temp.Value = -1;
                }
                else
                {
                    products.Add(temp.Id, temp);
                }
            }
            TrueMarkForProduct = products.Values.ToList();
        }
        // public List<TagPrefModel> Tags - ТЕГИПРЕФЫ
        // public List<CustomerTagGradesModel> TagGrades ТЕГИОЦЕНКИ

        private int GetWeightedAverageMark(List <CustomerTagGradesModel> allMarks, int id)
        {
            int i = 0;
            List<int> allTagGrades = new();
            while (i < allMarks.Count)
            {
                if (allMarks[i].Id == id)
                {
                    if (allMarks[i].Mark > 10)
                        allMarks[i].Mark = 10;
                    if (allMarks[i].Mark < 0)
                        allMarks[i].Mark = 0;
                    allTagGrades.Add(allMarks[i].Mark);
                }
                i++;
            }
            if (allTagGrades.Count == 2)
                return (allTagGrades[0] + allTagGrades[1]) / 2;
            else if (allTagGrades.Count == 1)
                return allTagGrades[0];
            return allTagGrades[allTagGrades.Count / 2];
        }
        public MapperConfiguration configTagPrefModel = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<TagPrefModel, GradePrefModel>();
        });
        public MapperConfiguration configCustomerTagGradesModel = new MapperConfiguration(cfg =>
            cfg.CreateMap<CustomerTagGradesModel, GradePrefModel>().ForMember(dest => dest.Value, act => act.MapFrom(src => src.Mark))
        );
        public void CheckForTag()
        {
            TrueMarkForTag = new();
            Dictionary<int, GradePrefModel> tages = new();
            foreach(var c in Preferences.Tags)
            {
                var temp = new Mapper(configTagPrefModel).Map<TagPrefModel, GradePrefModel>(c);
                if (c.IsInterested == true)
                    temp.Value = 11;
                else
                    temp.Value = -1;
                TrueMarkForTag.Add(temp);
                tages.Add(temp.Id, temp);
            }
            foreach(var c in Preferences.TagGrades)
            {
                if (tages.ContainsKey(c.Id) == false)
                {
                    c.Mark = GetWeightedAverageMark(Preferences.TagGrades, c.Id);
                }
                var temp = new Mapper(configCustomerTagGradesModel).Map<CustomerTagGradesModel, GradePrefModel>(c);
                if (tages.ContainsKey(temp.Id) == false)
                {
                    tages.Add(temp.Id, temp);
                    TrueMarkForTag.Add(temp);
                }
            }
        }

    }
}
