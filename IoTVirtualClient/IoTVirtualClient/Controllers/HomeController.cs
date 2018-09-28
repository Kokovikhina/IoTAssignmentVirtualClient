using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IoTVirtualClient.Helpers;
using IoTVirtualClient.Models;

namespace IoTVirtualClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetSignalInformation(string Status)
        {
            string status = Status.ToString();
          
            IbmConnectionManagement.DeviceClient(status);

            return Json(new { success = true });
        }
    }
}