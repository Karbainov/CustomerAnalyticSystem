using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.BLL.Test.TestCaseSource.CustomerTestCaseSource;
using CustomerAnalyticSystem.DAL.DTOs;
using CustomerAnalyticSystem.DAL.RepInterfaces;
using NUnit.Framework;
using System;
using CustomerAnalyticSystem.BLL.Services;
using CustomerAnalyticSystem.BLL.Test.TestCaseSource.ProductTestCaseSource;
using Moq;
using System.Collections.Generic;
using CustomerAnalyticSystem.DAL;

namespace CustomerAnalyticSystem.BLL.Test
{
    public class CustomerServiceTests
    {
        [TestCaseSource(typeof(GetAllCustomerTypeTestCaseSource))]
        public void GetAllCustomerTypeTest(List<CustomerTypeModel> expected, List<CustomerTypeDTO> customerTypeDTO)
        {
            Mock<ICustomerRepository> mock = new Mock<ICustomerRepository>();
            mock.Setup((obj) => obj.GetAllCustomerType()).Returns(customerTypeDTO);
            CustomerService customerService = new CustomerService((ICustomerRepository)mock.Object);

            List<CustomerTypeModel> actual = customerService.GetAllCustomerTypeModel();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(GetAllCustomerInfoDTOTestCaseSource))]
        public void GetAllCustomerInfoDTOTest(
            List<CustomerInfoDTO> customerInfoDTO
            , List<CustomerInfoModel> expected)
        {
            Mock<ICustomerRepository> mock = new Mock<ICustomerRepository>();
            mock.Setup((obj) => obj.GetAllCustomerInfoDTO()).Returns(customerInfoDTO);
            CustomerService customerService = new CustomerService((ICustomerRepository)mock.Object);

            List<CustomerInfoModel> actual = customerService.GetAllCustomerInfoModels();

            for (int i = 0; i < actual.Count; i++)
            {
                CollectionAssert.AreEqual(expected[i].Comments, actual[i].Comments);
                CollectionAssert.AreEqual(expected[i].Contacts, actual[i].Contacts);
            }
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
