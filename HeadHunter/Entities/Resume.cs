using HeadHunter.Enums;
using System;

namespace HeadHunter.Entities
{
    public class Resume
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public int WantedSalary { get; set; }
        public string Description { get; set; }
        public string Telegram { get; set; }
        public string Facebook { get; set; }
        public string LinkedIn { get; set; }
        public PublishStatus Status { get; set; }
        public DateTime RefreshDate { get; set; }
        public Category VacancyCategory { get; set; }
    }

}
