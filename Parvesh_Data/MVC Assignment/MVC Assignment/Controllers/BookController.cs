using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAC.Db_Operations;
using EntityModel;
using System.Linq;
namespace MVC_Assignment.Controllers
{
    public class BookController : Controller
    {
        IEventRepository _repository = null;
        public BookController(IEventRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("CreateEvent")]
        public ActionResult CreateEvent()
        {
            return View("CreateEvent");
        }

        [Route("CreateEvent")]
        [HttpPost]
        public ActionResult CreateEvent(EventModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.id = TempData["UserId"];
                
                TempData.Keep();
                int id = ViewBag.id;
                int ID = _repository.AddEvent(model,id);
                if (ID > 0)
                {
                    //return RedirectToAction("MyEvent", "Book");
                    //return View("Userpage");
                    return View("~/Views/Home/Userpage.cshtml");
                }
            }
            return View();
        }

        public ActionResult MyEvent()
        {
            var email = User.Identity.Name;
            List<EventModel> result = new List<EventModel>();
            if(email == "myadmin@bookevents.com")
            {
                result = _repository.AllEvent();
            }
            else
            {
                result = _repository.GetEvent(email);
            }
            return View(result);
        }

        public ActionResult AllEvents()
        {
            var allevent = _repository.AllEvent();
           foreach(var eve in allevent)
            {
                var com = _repository.GetComment(eve.Id);
                eve.Comment = com;
            }

            return View(allevent.ToList());
        }
        public ActionResult EventInvitedTo()
        {
            var email = User.Identity.Name;
            var result = _repository.EventInvited(email);
            return View(result);
        }


        public ActionResult Details(int id)
        {
            var com = _repository.GetComment(id);
            var result = _repository.GetEventDetails(id);
            result.Comment = com;
            if(result == null)
            {
                return RedirectToAction("GetEvents");
            }
            return View(result);
        }

        public ActionResult Edit(int id)
        {
            var result = _repository.GetEventDetails(id);
            return View(result);
        }
        [HttpPost]
        public ActionResult Edit(EventModel model)
        {
            if (ModelState.IsValid)
            {
                var result = _repository.UpdateBookEvent(model.Id, model);
                return RedirectToAction("MyEvent");
            }

            return View();
        }

        public ActionResult Delete(int id)
        {
            _repository.DeleteBookEvent(id);
            return RedirectToAction("MyEvent");
        }

        
    }
}
