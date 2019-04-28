using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return Redirect("/");
                //return new RedirectResult("/");
            }
            return Content("Hello from the comic book page!");
           /* return new ContentResult()
            {
                Content = "Hello from the comic book page!"
            };*/
            // Note this is all in green because thanks to the Controller MVC controller base class since 'we inheritid its functions
        }
    }
}