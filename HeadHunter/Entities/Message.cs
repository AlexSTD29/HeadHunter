namespace HeadHunter.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public int DialogId { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string MessageText { get; set; }
    }
}
