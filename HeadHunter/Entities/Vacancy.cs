using HeadHunter.Enums;
using System;

namespace HeadHunter.Entities
{
    public class Vacancy
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ExpirienceFrom { get; set; }
        public int ExpirienceTo { get; set; }
        public DateTime RefreshDate { get; set; }
        public PublishStatus Status { get; set; }
        public Category Category { get; set; }
    }
}
