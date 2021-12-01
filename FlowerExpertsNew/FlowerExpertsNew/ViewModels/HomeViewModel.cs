using FlowerExpertsNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerExpertsNew.ViewModels
{
    public class HomeViewModel
    {
        public FlowerExpertsTitle FlowerExpertsTitle { get; set; }
        public List<FlowerExpertsImage> FlowerExpertsImage { get; set; }
        public List<InformationList> InformationList { get; set; }
        public Valentine Valentine { get; set; }
        public TransitionVideo TransitionVideo { get; set; }

    }
}
