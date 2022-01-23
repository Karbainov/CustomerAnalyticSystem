using NUnit.Framework;
using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.DAL.RepInterfaces;
using CustomerAnalyticSystem.DAL.DTOs;
using CustomerAnalyticSystem.BLL.Services;
using System.Collections.Generic;
using Moq;
using System.Collections;
using CustomerAnalyticSystem.BLL.Test.TestCaseSourse;
using CustomerAnalyticSystem.BLL.Test.TestCaseSource.ProductTestCaseSource;

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

        //[TestCaseSource(typeof(UpdateTagByIdTestCaseSource))]
        //public void UpdateTagByIdTest(int id, string name, List<TagModel> expected)
        //{
        //    Mock<IProductTagGroupRepository> mock = new Mock<IProductTagGroupRepository>();
        //    mock.Setup((obj) => obj.UpdateTagById(id, name)).Verifiable();
        //    ProductTagGroupService productTagGroupRepository = new ProductTagGroupService((IProductTagGroupRepository)mock.Object);

        //    productTagGroupRepository.UpdateTagById(id, name);
            
        //    //CollectionAssert.AreEqual(expected, actual);
        //    mock.Verify();
        //}

        //[TestCaseSource(typeof(DeleteTagByIdTestCaseSource))]
        //public void DeleteTagByIdTest(int id, List<TagModel> expected)
        //{
        //    Mock<IProductTagGroupRepository> mock = new Mock<IProductTagGroupRepository>();
        //    mock.Setup((obj) => obj.DeleteTagById(id)).Verifiable();
        //    ProductTagGroupService productTagGroupRepository = new ProductTagGroupService((IProductTagGroupRepository)mock.Object);

        //    productTagGroupRepository.DeleteTagById(id);

        //   // CollectionAssert.AreEqual(expected, actual);
        //    mock.Verify();
        //}

        //[TestCaseSource(typeof(AddTagTestCaseSource))]
        //public void AddTagTest(string name, List<TagModel> expected)
        //{
        //    Mock<IProductTagGroupRepository> mock = new Mock<IProductTagGroupRepository>();
        //    mock.Setup((obj) => obj.AddTag(name)).Verifiable();
        //    ProductTagGroupService productTagGroupRepository = new ProductTagGroupService((IProductTagGroupRepository)mock.Object);

        //    productTagGroupRepository.AddTag(name);

        //    //CollectionAssert.AreEqual(expected, actual);
        //    mock.Verify();
        //}

        //#endregion

        //#region product

        //[TestCaseSource(typeof(GetAllProductsTestCaseSource))]
        //public void GetAllProductsTest(List<TagModel> expected, List<TagDTO> tagDTO)
        //{
        //    Mock<IProductTagGroupRepository> mock = new Mock<IProductTagGroupRepository>();
        //    mock.Setup((obj) => obj.GetAllTags()).Returns(tagDTO);
        //    ProductTagGroupService productTagGroupRepository = new ProductTagGroupService((IProductTagGroupRepository)mock.Object);

        //    List<TagModel> actual = productTagGroupRepository.GetAllTags();

        //    CollectionAssert.AreEqual(expected, actual);
        //}

        //[TestCaseSource(typeof(UpdateProductByIdTestCaseSource))]
        //public void UpdateProductByIdTest(int id, string name, List<TagModel> expected)
        //{
        //    Mock<IProductTagGroupRepository> mock = new Mock<IProductTagGroupRepository>();
        //    mock.Setup((obj) => obj.UpdateTagById(id, name)).Verifiable();
        //    ProductTagGroupService productTagGroupRepository = new ProductTagGroupService((IProductTagGroupRepository)mock.Object);

        //    productTagGroupRepository.UpdateTagById(id, name);

        //    //CollectionAssert.AreEqual(expected, actual);
        //    mock.Verify();
        //}

        //[TestCaseSource(typeof(DeleteProductByIdTestCaseSource))]
        //public void DeleteProductByIdTest(int id, List<TagModel> expected)
        //{
        //    Mock<IProductTagGroupRepository> mock = new Mock<IProductTagGroupRepository>();
        //    mock.Setup((obj) => obj.DeleteTagById(id)).Verifiable();
        //    ProductTagGroupService productTagGroupRepository = new ProductTagGroupService((IProductTagGroupRepository)mock.Object);

        //    productTagGroupRepository.DeleteTagById(id);

        //    // CollectionAssert.AreEqual(expected, actual);
        //    mock.Verify();
        //}

        //[TestCaseSource(typeof(AddProductTestCaseSource))]
        //public void AddProductTest(string name, List<TagModel> expected)
        //{
        //    Mock<IProductTagGroupRepository> mock = new Mock<IProductTagGroupRepository>();
        //    mock.Setup((obj) => obj.AddTag(name)).Verifiable();
        //    ProductTagGroupService productTagGroupRepository = new ProductTagGroupService((IProductTagGroupRepository)mock.Object);

        //    productTagGroupRepository.AddTag(name);

        //    //CollectionAssert.AreEqual(expected, actual);
        //    mock.Verify();
        //}

        //#endregion

        //#region product_tag

        //[TestCaseSource(typeof(GetAllProductsTestCaseSource))]
        //public void GetAllProduct_TagTest(List<Product_TagModel> expected, List<Product_TagDTO> tagDTO)
        //{
        //    Mock<IProductTagGroupRepository> mock = new Mock<IProductTagGroupRepository>();
        //    mock.Setup((obj) => obj.GetAllProduct_Tag()).Returns(tagDTO);
        //    ProductTagGroupService productTagGroupRepository = new ProductTagGroupService((IProductTagGroupRepository)mock.Object);

        //    List<TagModel> actual = productTagGroupRepository.GetAllTags();

        //    CollectionAssert.AreEqual(expected, actual);
        //}

        //[TestCaseSource(typeof(UpdateProductByIdTestCaseSource))]
        //public void UpdateProduct_TagByIdTest(int id, string name, List<TagModel> expected)
        //{
        //    Mock<IProductTagGroupRepository> mock = new Mock<IProductTagGroupRepository>();
        //    mock.Setup((obj) => obj.UpdateTagById(id, name)).Verifiable();
        //    ProductTagGroupService productTagGroupRepository = new ProductTagGroupService((IProductTagGroupRepository)mock.Object);

        //    productTagGroupRepository.UpdateTagById(id, name);

        //    //CollectionAssert.AreEqual(expected, actual);
        //    mock.Verify();
        //}

        //[TestCaseSource(typeof(DeleteProductByIdTestCaseSource))]
        //public void DeleteProduct_TagByIdTest(int id, List<TagModel> expected)
        //{
        //    Mock<IProductTagGroupRepository> mock = new Mock<IProductTagGroupRepository>();
        //    mock.Setup((obj) => obj.DeleteTagById(id)).Verifiable();
        //    ProductTagGroupService productTagGroupRepository = new ProductTagGroupService((IProductTagGroupRepository)mock.Object);

        //    productTagGroupRepository.DeleteTagById(id);

        //    // CollectionAssert.AreEqual(expected, actual);
        //    mock.Verify();
        //}

        //[TestCaseSource(typeof(AddProductTestCaseSource))]
        //public void AddProduct_TagTest(string name, List<TagModel> expected)
        //{
        //    Mock<IProductTagGroupRepository> mock = new Mock<IProductTagGroupRepository>();
        //    mock.Setup((obj) => obj.AddTag(name)).Verifiable();
        //    ProductTagGroupService productTagGroupRepository = new ProductTagGroupService((IProductTagGroupRepository)mock.Object);

        //    productTagGroupRepository.AddTag(name);

        //    //CollectionAssert.AreEqual(expected, actual);
        //    mock.Verify();
        //}

        //#endregion

        //#region group

        //[TestCaseSource(typeof(GetAllProductsTestCaseSource))]
        //public void GetAllProductsTest(List<TagModel> expected, List<TagDTO> tagDTO)
        //{
        //    Mock<IProductTagGroupRepository> mock = new Mock<IProductTagGroupRepository>();
        //    mock.Setup((obj) => obj.GetAllTags()).Returns(tagDTO);
        //    ProductTagGroupService productTagGroupRepository = new ProductTagGroupService((IProductTagGroupRepository)mock.Object);

        //    List<TagModel> actual = productTagGroupRepository.GetAllTags();

        //    CollectionAssert.AreEqual(expected, actual);
        //}

        //[TestCaseSource(typeof(UpdateProductByIdTestCaseSource))]
        //public void UpdateProductByIdTest(int id, string name, List<TagModel> expected)
        //{
        //    Mock<IProductTagGroupRepository> mock = new Mock<IProductTagGroupRepository>();
        //    mock.Setup((obj) => obj.UpdateTagById(id, name)).Verifiable();
        //    ProductTagGroupService productTagGroupRepository = new ProductTagGroupService((IProductTagGroupRepository)mock.Object);

        //    productTagGroupRepository.UpdateTagById(id, name);

        //    //CollectionAssert.AreEqual(expected, actual);
        //    mock.Verify();
        //}

        //[TestCaseSource(typeof(DeleteProductByIdTestCaseSource))]
        //public void DeleteProductByIdTest(int id, List<TagModel> expected)
        //{
        //    Mock<IProductTagGroupRepository> mock = new Mock<IProductTagGroupRepository>();
        //    mock.Setup((obj) => obj.DeleteTagById(id)).Verifiable();
        //    ProductTagGroupService productTagGroupRepository = new ProductTagGroupService((IProductTagGroupRepository)mock.Object);

        //    productTagGroupRepository.DeleteTagById(id);

        //    // CollectionAssert.AreEqual(expected, actual);
        //    mock.Verify();
        //}

        //[TestCaseSource(typeof(AddProductTestCaseSource))]
        //public void AddProductTest(string name, List<TagModel> expected)
        //{
        //    Mock<IProductTagGroupRepository> mock = new Mock<IProductTagGroupRepository>();
        //    mock.Setup((obj) => obj.AddTag(name)).Verifiable();
        //    ProductTagGroupService productTagGroupRepository = new ProductTagGroupService((IProductTagGroupRepository)mock.Object);

        //    productTagGroupRepository.AddTag(name);

        //    //CollectionAssert.AreEqual(expected, actual);
        //    mock.Verify();
        //}

        #endregion

    }


}