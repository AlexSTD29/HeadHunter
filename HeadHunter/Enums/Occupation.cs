using System.ComponentModel;

namespace HeadHunter.Enums
{
    public enum Occupation
    {
        [Description("Работодатель")]
        Employer = 0,
        [Description("Соискатель")]
        Applicant = 1
    }
}
