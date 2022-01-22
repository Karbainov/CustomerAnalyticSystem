using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CustomerAnalyticSystem.BLL.Models;

namespace CustomerAnalyticSystem.BLL.Analytics.ProductInfoModel
{
    public class ConcreteCustomer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }

        public GeneralStatistics InfoToAnalise { get; set; }

        public Dictionary<int , ItemToRecommend> ProductsRecommends { get; set; }
        public Dictionary<int, ItemToRecommend> GroupsRecommends { get; set; }
        public Dictionary<int, ItemToRecommend> TagsRecommends { get; set; }

        public ConcreteCustomer(GeneralStatistics info, CustomerInfoModel customer)
        {
            InfoToAnalise = info;
            Id = customer.Id;
            FirstName = customer.FirstName;
            LastName = customer.LastName;
            ProductsRecommends = info.Products;
            GroupsRecommends = info.Groups;
            TagsRecommends = info.Tags;
        }

        //private int GetAverageMark(List<int> marks)
        //{
        //    if ()
        //        //TODO
        //        //нижний метод делает словарь ключ ИД продукта - велью - все оценки продукта
        //        //может переделать на айди кастомера
        //}
        public void AvgMarkForEveryProduct()
        {
            //Dictionary<int, List<int>> allProductMarks = new();
            //foreach(var grade in InfoToAnalise.Info.Grades)
            //{
            //    if (allProductMarks.ContainsKey(grade.ProductId) == false)
            //    {
            //        allProductMarks[grade.ProductId] = new();
            //    }
            //    allProductMarks[grade.ProductId].Add(grade.Value);
            //}
            //for (int i = 0; i < allProductMarks.Count; i++)
            //{
            //    int avgMark = 
            //}
        }

    }
}
