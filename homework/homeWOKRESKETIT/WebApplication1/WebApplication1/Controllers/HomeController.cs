using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft;
using Newtonsoft.Json;
using System.IO;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            string text = "1";

            //return View();
            return Json(text,JsonRequestBehavior.AllowGet);
        }

        public ActionResult Read(string path)
        {
            var text = System.IO.File.ReadAllText(path,System.Text.Encoding.UTF8);
            return Json(text, JsonRequestBehavior.AllowGet);
        }

       

        public ActionResult Write(string JsonContent)
        {
            var content = JsonConvert.DeserializeObject<Content>(JsonContent);
            
            System.IO.File.WriteAllText(content.path, content.text);
            return Json(content.text, JsonRequestBehavior.AllowGet);
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
    public class Content
    {
        public string path { get; set; }
        public string text { get; set; }
    }
}