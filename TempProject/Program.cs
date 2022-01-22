using CustomerAnalyticSystem.DAL.DTOs;
using CustomerAnalyticSystem.DAL;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.BLL.Services;

namespace TempProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            var group = new ProductTagGroupService();
            group.UpdateGroupById(10, "hjgfdsa", "TextBoxDescription.Text");
        }
    }
}