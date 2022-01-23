namespace CustomerAnalyticSystem.BLL.Models
{
    public class CommentModel
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return $"{Text}";
        }
    }
}
