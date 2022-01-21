using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CustomerAnalyticSystem.BLL.Models;


namespace CustomerAnalyticSystem.BLL.Analytics.ProductInfoModel
{
    public class MrFucky
    {
        private StackModel Info;
        public Dictionary<int,ItemToRecommend> Products { get; set; }
        public Dictionary<int, ItemToRecommend> Groups { get; set; }
        public Dictionary<int, ItemToRecommend> Tags { get; set; }
        public Dictionary<int,List<int>> TagsByProductId { get; set; }
        public Dictionary<int, List<int>> GroupsByProductId { get; set; }
        public Dictionary<int, List<int>> CheckInOrders { get; set; }
        public int AmountOfOrders { get; set; }

        public MrFucky(StackModel allLists)
        {
            Info = allLists;
            Products = new();
            Groups = new();
            Tags = new();
            AmountOfOrders = Info.Orders.Count;
        }

        public MapperConfiguration configuration = new(cfg =>
        {
            cfg.CreateMap<ProductBaseModel,ItemToRecommend>();
            cfg.CreateMap<GroupBaseModel, ItemToRecommend>();
            cfg.CreateMap<TagModel, ItemToRecommend>();
        });

        #region fill sht
        public void FillProducts()
        {
            foreach(var product in Info.Products)
            {
                if (Products.ContainsKey(product.Id) == false)
                {
                    var map = new Mapper(configuration)
                        .Map<ProductBaseModel,ItemToRecommend>(product);
                    Products.Add(map.Id, map);
                }
            }
        }
        public void FillGroups()
        {
            foreach(var group in Info.Groups)
            {
                if (Groups.ContainsKey(group.Id) == false)
                {
                    var map = new Mapper(configuration)
                        .Map<GroupBaseModel, ItemToRecommend>(group);
                    Groups.Add(map.Id, map);
                }

            }
        }

        public void FillTags()
        {
            foreach (var tag in Info.Tags)
            {
                if (Tags.ContainsKey(tag.Id) == false)
                {
                    var map = new Mapper(configuration)
                        .Map<TagModel, ItemToRecommend>(tag);
                    Tags.Add(map.Id, map);
                }
            }
        }
        #endregion

        #region связка продуктов
        public void GetListOfAllTagsInProduct() 
        {
            TagsByProductId = new();
            foreach(var c in Info.Product_Tag)
            {
                if (TagsByProductId.ContainsKey(c.TagId) == false)
                {
                    TagsByProductId.Add(c.TagId, new());
                }
                TagsByProductId[c.TagId].Add(c.ProductId);
            }
        }

        public void GetListOfAllGroupsInProduct()
        {
            GroupsByProductId = new();
            foreach (var product in Info.Products)
            {
                if (GroupsByProductId.ContainsKey(product.GroupId) == false)
                {
                    GroupsByProductId.Add(product.GroupId, new());
                }
                GroupsByProductId[product.GroupId].Add(product.Id);
            }
        }

        public void PutAllCheckByOrders()
        {
            CheckInOrders = new();
            foreach(var check in Info.Checks)
            {
                if (CheckInOrders.ContainsKey(check.OrderId) == false)
                {
                    CheckInOrders.Add(check.OrderId, new());
                }
                CheckInOrders[check.OrderId].Add(check.)
            }
        }
        #endregion
        public void FindAllBestsellers()
        {
            foreach(var product in Info.Products)
            {
                foreach(var order in Info.Orders)
                {
                    foreach(var checkPos in Info.Checks)
                    {
                        if()
                    }
                }
            }
        }
    }
}
