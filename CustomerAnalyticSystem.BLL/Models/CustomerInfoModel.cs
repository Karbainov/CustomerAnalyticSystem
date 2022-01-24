using System.Collections.Generic;

namespace CustomerAnalyticSystem.BLL.Models
{
    public class CustomerInfoModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TypeId { get; set; }
        public string Name { get; set; }
        public List<ContactModel> Contacts { get; set; }
        public List<CommentModel> Comments { get; set; }

        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName} {TypeId}";
        }

        
    }
}