using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse,Genre=" + genre);
            return message;
        }
        public string Details()
        {
            return "hello from store.details()";
        }
    }
}