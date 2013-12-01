using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IS445.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WebForm()
        {
            return View();
        }

        public ActionResult Bio()
        {
            return View();
        }
        public ActionResult AbsoluteLayout()
        {
            return View();
        }
        public ActionResult StaticLayout()
        {
            return View();
        }
        public ActionResult FloatLayout()
        {
            return View();
        }
        public ActionResult ClientSideDemo()
        {
            return View();
        }
        public ActionResult ServerSideDemo()
        {
            return View();
        }

        public ActionResult FormatPhoneNumber(string inputNumber)
        {

            if (string.IsNullOrEmpty(inputNumber))
            {
                return Content("invalid input, please try again");
            }
            else
            {
                string formatted = formatNumber(inputNumber);
                return View((object)formatted);
            }
        }

        // please implement your phone number formatting logic here
        private string formatNumber(string inputNumber)
        {
            // imiplement formatting here

            string finalstring = inputNumber;

            inputNumber = String.Concat("(", finalstring.Substring(0, 3), ") ", finalstring.Substring(3, 3), "-", finalstring.Substring(6, 4));

            return "formated number is: " + inputNumber;
        }
    }
}
