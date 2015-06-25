using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCReceivedJson.Web.UI.Models;

namespace MVCReceivedJson.Web.UI.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public void ReceivedJson(Produto dadosEnviados)
        {
            
        }
    }
}