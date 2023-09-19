using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DAC.Db_Operations;
using EntityModel;

namespace MVC_Assignment.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        private readonly IUserRepository _userRepository;
        private readonly IEventRepository _eventRepository;
        public HomeController(IUserRepository userRepository, IEventRepository eventRepository)
        {
            _userRepository = userRepository;
            _eventRepository = eventRepository;
        }
        [Route("signup")]
        public IActionResult SignUp()
        {
            return View();
        }

        [Route("signup")]
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpUserModel usermodel)
        {
            if (ModelState.IsValid)
            {

                var result = await _userRepository.CreateUserAsync(usermodel);
                if (!result.Succeeded)
                {
                    foreach (var errorMessage in result.Errors)
                    {
                        ModelState.AddModelError("", errorMessage.Description);
                    }
                    return View(usermodel);
                }
                ModelState.Clear();
            }
            return View();
        }

        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("Login")]
        [HttpPost]
        public async Task<IActionResult> Login(SignInUserModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userRepository.PasswordLogInAsync(model);
                if (result.Succeeded)
                {
                    TempData["id"] = model.id;
                    TempData["Email"] = model.Email;
                    return View("UserPage");
                }
                ModelState.AddModelError("", "Invalid Credentials");
            }
            return View("Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult PublicEvents()
        {
            var result = _eventRepository.PublicEvent();
            return View(result.ToList());
        }

        public IActionResult UpcomingEvents()
        {
            var result = _eventRepository.UpcomingEvent();
            return View(result.ToList());
        }

        public IActionResult PastEvents()
        {
            var result = _eventRepository.PastEvents();
            return View(result.ToList());
        }

        public ActionResult Details(int id)
        {
            var com = _eventRepository.GetComment(id);
            var result = _eventRepository.GetEventDetails(id);
            result.Comment = com;
            if (result == null)
            {
                return RedirectToAction("GetEvents");
            }
            return View(result);
        }
    }
}
