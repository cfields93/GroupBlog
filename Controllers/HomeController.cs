using GroupBlog.Models;
using GroupBlog.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroupBlog.Controllers
{

    public class HomeController : Controller
    {
        //private BlogRepository _blogRepository;
        public HomeController()
        {
            
        }

        public ActionResult AddBlog()
        {
            return RedirectToAction("AddBlog", "Account");
        }
        public ActionResult Index()
        {
            BlogRepository _blogRepository = new BlogRepository();
            List<Blog> blogs = new List<Blog>();
            if (_blogRepository.GetAll() != null)
            {
                blogs = _blogRepository.GetAll();
            }

            return View(blogs);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}