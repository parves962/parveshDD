using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAC.Db_Operations;
using EntityModel;
using MVC_Assignment.CommentObserver;

namespace MVC_Assignment.Controllers
{
    public class CommentController : Controller
    {
        IEventRepository _repository = null;
        public CommentController(IEventRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ShowComment(CommentModel model)
        {
            var result = _repository.GetComment(model.id);
            TempData["Comments"] = result.ToList();
            return View(result.ToList());
        }

        [Route("Comment")]
        //public ActionResult AddComment()
        //{
        //    return View();
        //}

        [HttpPost]
        public ActionResult AddComment(CommentModel model)
        {
            var name = User.Identity.Name;
            model.UserName = name;

            int result = _repository.AddComment(model);

            Observer obj = new Observer(model.EventId, model.UserName, model.Comment);
            obj.Notify(obj);
            if(result > 0)
            {
                return RedirectToAction("Details","Home",new { id = model.EventId });
            }
            //var result1 = _repository.GetComment();
            return View();
        }

       
    }
}
