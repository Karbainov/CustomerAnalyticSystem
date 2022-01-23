using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.BLL.Services;
using CustomerAnalyticSystem.BLL.Test.TestCaseSource.ProductTestCaseSource;
using CustomerAnalyticSystem.BLL.Test.TestCaseSourse;
using CustomerAnalyticSystem.DAL.DTOs;
using CustomerAnalyticSystem.DAL.RepInterfaces;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace CustomerAnalyticSystem.BLL.Test
{
    public class ProductTagGroupServiceTests
    {

        #region tag

        [TestCaseSource(typeof(GetAllTagsTestCaseSource))]
        public void GetAllTagsTest(List<TagModel> expected, List<TagDTO> tagDTO)
        {
            Mock<IProductTagGroupRepository> mock = new Mock<IProductTagGroupRepository>();
            mock.Setup((obj) => obj.GetAllTags()).Returns(tagDTO);
            ProductTagGroupService productTagGroupRepository = new ProductTagGroupService((IProductTagGroupRepository)mock.Object);

            List<TagModel> actual = productTagGroupRepository.GetAllTags();

            CollectionAssert.AreEqual(expected, actual);
        }



        #endregion

        #region product

        [TestCaseSource(typeof(GetAllProductsTestCaseSource))]
        public void GetAllProductsTest(List<TagModel> expected, List<TagDTO> tagDTO)
        {
            Mock<IProductTagGroupRepository> mock = new Mock<IProductTagGroupRepository>();
            mock.Setup((obj) => obj.GetAllTags()).Returns(tagDTO);
            ProductTagGroupService productTagGroupRepository = new ProductTagGroupService((IProductTagGroupRepository)mock.Object);

            List<TagModel> actual = productTagGroupRepository.GetAllTags();

            CollectionAssert.AreEqual(expected, actual);
        }

        #endregion

        #region product_tag

        [TestCaseSource(typeof(GetAllProductsTestCaseSource))]
        public void GetAllProduct_TagTest(List<Product_TagModel> expected, List<Product_TagDTO> tagDTO)
        {
            Mock<IProductTagGroupRepository> mock = new Mock<IProductTagGroupRepository>();
            mock.Setup((obj) => obj.GetAllProduct_Tag()).Returns(tagDTO);
            ProductTagGroupService productTagGroupRepository = new ProductTagGroupService((IProductTagGroupRepository)mock.Object);

            List<TagModel> actual = productTagGroupRepository.GetAllTags();

            CollectionAssert.AreEqual(expected, actual);
        }


        #endregion

        #region group

        [TestCaseSource(typeof(GetAllProductsTestCaseSource))]
        public void GetAllProductsTest(List<TagModel> expected, List<TagDTO> tagDTO)
        {
            Mock<IProductTagGroupRepository> mock = new Mock<IProductTagGroupRepository>();
            mock.Setup((obj) => obj.GetAllTags()).Returns(tagDTO);
            ProductTagGroupService productTagGroupRepository = new ProductTagGroupService((IProductTagGroupRepository)mock.Object);

            List<TagModel> actual = productTagGroupRepository.GetAllTags();

            CollectionAssert.AreEqual(expected, actual);
        }

        #endregion




        //public List<ProductsWithGroupsDTO> GetAllProductsByGroupId(int id);
        //public List<TagDTO> GetAllTagsByProductId(int id);
        //public List<ProductsWithGroupsDTO> GetAllProductsByTag(int id);
        //public List<ProductsWithGroupsDTO> GetAllProductsWithGroups();
        //public List<GroupsWithProductsDTO> GetAllGroupsWithProducts();

    }


}