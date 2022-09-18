﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VHaaSh.WEB.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        
        //test11

        [AllowAnonymous] //Filter

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome()
        {
            //welcome test
            return View();
        }
    }
}