using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.BLL.Test;
using CustomerAnalyticSystem.DAL.DTOs;

namespace CustomerAnalyticSystem.BLL.Test.TestCaseSourse
{
    public class UpdateTagByIdTestCaseSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int id = 1;
            string name = "uuu";
            List<TagModel> expected = new List<TagModel>() { new TagModel() { Id = 1, Name = "uuu" }, new TagModel() { Id = 3, Name = "qweqwe" } };
            yield return new object[] { id, name, expected};

            int id2 = 4;
            string name2 = "uuu";
            List<TagModel> expected2 = new List<TagModel>() { new TagModel() { Id = 1, Name = "fjffjf" }, new TagModel() { Id = 4, Name = "uuu" } };
            yield return new object[] { id2, name2, expected2};

        }
    }
}
