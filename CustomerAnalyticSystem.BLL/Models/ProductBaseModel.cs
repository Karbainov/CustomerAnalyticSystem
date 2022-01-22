namespace CustomerAnalyticSystem.BLL.Models
{
    public class ProductBaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string GroupName { get; set; }
        public int GroupId { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Description} {GroupName}";
        }

    }
}
