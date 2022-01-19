﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.DAL;
using CustomerAnalyticSystem.DAL.DTOs;

namespace CustomerAnalyticSystem.BLL
{
    public class CustomerService
    {
        public CustomerInfoModel GetCustomerModel(int id)
        {
            CustomerTypeCustomerCommentRepository rep = new CustomerTypeCustomerCommentRepository();
            var DTO = rep.GetCustomerInfoService(id);
            var map = new MrMappi();
            CustomerInfoModel result = map.MapCustomerInfoDTOToCustomerModel(DTO);

            return result;
        }

        public List<CustomerModel> GetAllCustomerModels()
        {
            CustomerTypeCustomerCommentRepository rep = new CustomerTypeCustomerCommentRepository();
            List<CustomerDTO> customers = rep.GetAllCustomers();
            var map = new MrMappi();

            return  map.MapListCustomerDTOToListCustomerModel(customers);
        }

        public void UpdateCustomer(int id, string firstName, string lastName, int TypeId = 1)
        {
            CustomerTypeCustomerCommentRepository rep = new CustomerTypeCustomerCommentRepository();
            rep.UpdateCustomerById(id, firstName, lastName, TypeId);
        }
    }
}