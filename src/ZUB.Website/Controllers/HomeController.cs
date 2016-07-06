using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZUB.Domain;

namespace ZUB.Website.Controllers
{
    public class HomeController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unit)
        {
            _unitOfWork = unit;
        }

        public IActionResult Index()
        {
            return View(_unitOfWork.Doctors.GetAll());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
