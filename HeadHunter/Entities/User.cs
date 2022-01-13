using HeadHunter.Enums;
using Microsoft.AspNetCore.Identity;

namespace HeadHunter.Entities
{
    public class User : IdentityUser
    {
        public string Avatar { get; set; }
        public Occupation Occupation { get; set; }
    }
}
