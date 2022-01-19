using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.DAL;
using CustomerAnalyticSystem.DAL.DTOs;

namespace CustomerAnalyticSystem.BLL.Services
{
    public class ContactTypeContactService
    {
        public void UpdateContact (int id, int customerId, int contactType, string value, string name)
        {
            ContactTypeContactRepository rep = new ContactTypeContactRepository();
            rep.UpdateContact(id, customerId, contactType, value);
        }

        public void DeleteContact (int id)
        {
            ContactTypeContactRepository rep = new ContactTypeContactRepository();
            rep.DeleteContact(id);
        }
        
        public void UpdateContactType (int id, string name)
        {
            ContactTypeContactRepository rep = new ContactTypeContactRepository();
            rep.UpdateContactType(id, name);
        }

        public void DeleteContactType(int id)
        {
            ContactTypeContactRepository rep = new ContactTypeContactRepository();
            rep.DeleteContactType(id);
        }


    }
}
