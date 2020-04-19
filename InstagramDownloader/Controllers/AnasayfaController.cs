using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace InstagramDownloader.Controllers
{
    [SessionState(SessionStateBehavior.Disabled)]
    public class AnasayfaController : Controller
    {
        // GET: Anasayfa
        public ActionResult Index()
        {
            return View();
        }
       
    }
}