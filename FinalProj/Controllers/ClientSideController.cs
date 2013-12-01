﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IS445.Controllers
{
    public class ClientSideController : Controller
    {
        //
        // GET: /ClientSideDemo/


        public ActionResult ClientSide()
        {
            return View();
        }

        public ActionResult FormatStringBackwards(string inputString)
        {

            if (string.IsNullOrEmpty(inputString))
            {
                return Content("invalid input, please try again");
            }
            else
            {
                string formatted = formatString(inputString);
                return View((object)formatted);
            }
        }

        private string formatString(string inputString)
        {
            // imiplement formatting here
            string finalstring = "";

            string[] words = inputString.Split(' ');
            foreach (string word in words)
            {
                finalstring = String.Concat(word, " ", finalstring);
            }

            return "formated number is: " + finalstring;
        }

    }
}
