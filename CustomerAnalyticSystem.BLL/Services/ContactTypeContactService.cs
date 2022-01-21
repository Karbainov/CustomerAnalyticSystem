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

        public List<ContactTypeModel> GetAllContactTypeModel()
        {
            ContactTypeContactRepository rep = new ContactTypeContactRepository();
            List<ContactTypeDTO> DTO = rep.GetAllContactType();
            MrMappi map = new MrMappi();
            return map.MapFromContactTypeDTOToContactTypeModel(DTO);
        }

        public void AddContact(ContactBaseModel contact)
        {
            ContactTypeContactRepository rep = new ContactTypeContactRepository();
            rep.AddContact(contact.CustomerId, contact.ContactTypeId, contact.Value);
        }

        public void UpdateContact (int id, int customerId, int contactTypeId, string value)
        {
            ContactTypeContactRepository rep = new ContactTypeContactRepository();
            rep.UpdateContact(id, customerId, contactTypeId, value);
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

        public List<ContactModel> GetAllContactModelByCustomerId(int id)
        {
            List<ContactModel> contacts = new List<ContactModel>();
            ContactTypeContactRepository rep = new ContactTypeContactRepository();
            var DTOs = rep.GetAllContactWithContactTypeByCustomerId(id);
            MrMappi map = new MrMappi();
            return map.MapFromContactWithContactTypeNameDTOToContactModel(DTOs);
        }
    }
}
