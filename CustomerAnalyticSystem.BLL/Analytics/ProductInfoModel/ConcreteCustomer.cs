using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CustomerAnalyticSystem.BLL.Models;
using static CustomerAnalyticSystem.BLL.Analytics.ProductInfoModel.GeneralStatistics;

namespace CustomerAnalyticSystem.BLL.Analytics.ProductInfoModel
{
    public class ConcreteCustomer
    {
        public GeneralStatistics InfoToAnalise { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }


        public Dictionary<int , ItemToRecommend> ProductsRecommends { get; set; }
        public Dictionary<int, ItemToRecommend> GroupsRecommends { get; set; }
        public Dictionary<int, ItemToRecommend> TagsRecommends { get; set; }



        public Dictionary<int, List<int>> AllOneProductMarks { get; set; }//держит для каждого продукта список оценок кастомера
        public Dictionary<int, int> PreferenceByProductId { get; set; }//Ключ - айди продукта, велью его преф (-1 / 1)
        public Dictionary<int, int> PreferenceByTagId { get; set; }
        public Dictionary<int, int> PreferenceByGroupId { get; set; }


        public Dictionary<int, int> ProductPercent { get; set; }
        public Dictionary<int, int> ProductAvgGrade { get; set; }//key = prId, val = avgGrade
        public int AllcustomerOrders { get; set; }
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


        public void AllocatePlaceesForGroupsAndTags()
        {
            List<GroupBaseModel> grps = InfoToAnalise.Info.Groups;
            foreach(var group in grps)
            {
                GroupsRecommends.Add(group.Id, new(group.Id, group.Name));
            }
            foreach(var tag in InfoToAnalise.Info.Tags)
            {
                TagsRecommends.Add(tag.Id, new(tag.Id, tag.Name));
            }
        }

        public ConcreteCustomer()
        {
            ProductsRecommends = new();
            GroupsRecommends = new();
            TagsRecommends = new();
           
        }

        public void IncludeStatistics(GeneralStatistics stats)
        {
            InfoToAnalise = stats;
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
        public void GetPopularityGroup(List<int> groups)
        {
            for (int i = 0; i < groups.Count; i++)
            {
                if (groups[i] == ((int)IsContain.Contain))
                {

                    GroupsRecommends.Values.ElementAt(i).Percent++;
                    
                }
            }
        }


        public void GetPopularityTag(List<int> tags)
        {
            for (int i = 0; i < tags.Count; i++)
            {
                if (tags[i] == -555)
                {
                    TagsRecommends.Values.ElementAt(i).Percent++;
                }
            }
        }
        private enum ConvertToPercent
        {
            product = 1,
            group = 2,
            tag = 3
        };

        private void GetPercents(ConvertToPercent type)
        {
            if (AllcustomerOrders == 0)
                return;
            if (type is ConvertToPercent.group)
            {
                for (int i = 0; i < GroupsRecommends.Count; i++)
                {
                    var group = GroupsRecommends.ElementAt(i);
                        GroupsRecommends[group.Key].Percent = (GroupsRecommends[group.Key].Percent * 100) / AllcustomerOrders;
                }
            }
            else if (type is ConvertToPercent.tag)
            {
                for (int i = 0; i < TagsRecommends.Count; i++)
                {
                    var tag = TagsRecommends.ElementAt(i);


                    TagsRecommends[tag.Key].Percent = (TagsRecommends[tag.Key].Percent * 100) / AllcustomerOrders;
                }
                foreach(var tag in TagsRecommends)
                {
                    if (tag.Value.Percent == 0)
                        TagsRecommends.Remove(tag.Key);
                }
            }
        }

        public void GetAllCurrentCustomerOrders()
        {
            int cnt = 0;
            foreach(var order in InfoToAnalise.Info.Orders)
            {
                if (order.CustomerId == this.Id)
                    cnt++;
            }
            AllcustomerOrders = cnt;
            GetPercents(ConvertToPercent.group);
            GetPercents(ConvertToPercent.tag);
        }

    }
}
