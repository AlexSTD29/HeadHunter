using HeadHunter.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HeadHunter.Models
{
    public class HeadHunterContext : IdentityDbContext<User>
    {
        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Expirience> Expiriences { get; set; }
        public DbSet<Dialog> Dialogs { get; set; }
        public DbSet<Message> Messages { get; set; }
        public HeadHunterContext(DbContextOptions<HeadHunterContext> options) : base(options) { }
    }
}
