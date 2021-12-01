using FlowerExpertsNew.DAL;
using FlowerExpertsNew.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerExpertsNew.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;
        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var flowerExpertsImage = _dbContext.FlowerExpertsImages.ToList();
            var flowerExpertsTitle = _dbContext.FlowerExpertsTitles.SingleOrDefault();
            var Valentine = _dbContext.Valentine.SingleOrDefault();
            var TransitionVideo = _dbContext.TransitionVideo.SingleOrDefault();
            var InformationList = _dbContext.InformationList.ToList();



            return View(new HomeViewModel 
            {
                FlowerExpertsImage = flowerExpertsImage,
                FlowerExpertsTitle = flowerExpertsTitle,
                InformationList= InformationList,
                Valentine= Valentine,
                TransitionVideo= TransitionVideo

            });
        }
    }
}
