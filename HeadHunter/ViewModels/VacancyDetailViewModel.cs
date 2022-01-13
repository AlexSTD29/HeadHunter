using HeadHunter.Entities;
using System.Collections.Generic;

namespace HeadHunter.ViewModels
{
    public class VacancyDetailViewModel
    {
        public Vacancy Vacancy { get; set; }
        public IEnumerable<Resume> Resumes { get; set; }
    }
}
