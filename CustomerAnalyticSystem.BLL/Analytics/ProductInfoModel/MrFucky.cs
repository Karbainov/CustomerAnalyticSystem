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

        //словарь рекомендаций
        public Dictionary<int,ItemToRecommend> Products { get; set; }//+
        public Dictionary<int, ItemToRecommend> Groups { get; set; }
        public Dictionary<int, ItemToRecommend> Tags { get; set; }


        //словарь который соотносит все теги с продуктом и группы с продуктом
        public Dictionary<int,List<int>> TagsByProductId { get; set; }
        public Dictionary<int, List<int>> GroupsByProductId { get; set; }

        //словарь соотносит айди чека с ордером
        public Dictionary<int, List<int>> ChecksInOrder { get; set; }
        public Dictionary<int, int> CheckProduct { get; set; }

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
        public void FillProducts()// все продукты
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
        public void FillGroups()//все группы
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

        public void FillTags()//заполняет все теги
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
        public void GetListOfAllTagsInProduct() //связывает теги в группы
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

        public void GetListOfAllGroupsInProduct()//связывает продукты в группы
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

        public void PutAllCheckByOrders()// связывает все чеки с ордерами
        {
            ChecksInOrder = new();
            foreach (var check in Info.Checks)
            {
                if (ChecksInOrder.ContainsKey(check.OrderId) == false)
                {
                    ChecksInOrder.Add(check.OrderId, new());
                }
                ChecksInOrder[check.OrderId].Add(check.Id);
            }
        }
        public void BoundCheckProduct()// связывает айди чека с айдипродукта
        {
            CheckProduct = new();
            foreach(var check in Info.Checks)
            {
                CheckProduct.Add(check.Id, check.ProductId);
            }
        }
        #endregion

        private bool IsContains(int id, int prodId)//проверка на появление продукта в заказе (по чеку)
        {
            List<int> oneOrder;

            if (ChecksInOrder.ContainsKey(id) == false)
            {
                return false;
            }
            for(int i = 0; i < ChecksInOrder[id].Count; i++)
            {
                oneOrder = ChecksInOrder[id];
                if(CheckProduct[oneOrder[i]] == prodId)
                {
                    return true;
                }
            }
            return false;
        }
        public void FindAllBestsellers()//количество появления продукта в каждом заказе
        {
            BoundCheckProduct();

            foreach (var order in Info.Orders)
            {
                foreach(var prod in Products)
                {
                    if (IsContains(order.Id, prod.Key))
                    {
                        prod.Value.Percent++;
                    }
                }
            }
        }
    }
}
