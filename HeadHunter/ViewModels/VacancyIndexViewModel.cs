using System.Collections.Generic;
using HeadHunter.Entities;

namespace HeadHunter.ViewModels
{
    public class VacancyIndexViewModel
    {
        public int DialogCount { get; set; }
        public List<Vacancy> Vacancies { get; set; }
    }
}
