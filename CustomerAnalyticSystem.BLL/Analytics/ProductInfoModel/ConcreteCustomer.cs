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

        public Dictionary<int, List<int>> AllOneProductMarks { get; set; }//держит для каждого продукта список оценок кастомера

        public Dictionary<int, int> ProductAvgGrade { get; set; }//key = prId, val = avgGrade
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
        public ConcreteCustomer()
        {

        }
        //private int GetAverageMark(List<int> marks)
        //{
        //    if ()
        //        //TODO
        //        //нижний метод делает словарь ключ ИД продукта - велью - все оценки продукта
        //        //может переделать на айди кастомера
        //}

        public int GetAvgProductMark(List<int> marks)
        {
            if (marks.Count == 1)
                return marks[0];
            else if (marks.Count == 2)
                return (marks[0] + marks[1]) / 2;
            else
                return marks[marks.Count / 2];
        }
        public void AvgMarkForEveryProduct()
        {
            ProductAvgGrade = new();
            foreach(var c in AllOneProductMarks)
            {
                ProductAvgGrade.Add(c.Key, GetAvgProductMark(c.Value));
            }
        }

    }
}
