using HeadHunter.Entities;
using System.Collections.Generic;

namespace HeadHunter.ViewModels
{
    public class DialogViewModel
    {
        public Dialog Dialog { get; set; }
        public List<Message> Messages { get; set; }
    }
}
