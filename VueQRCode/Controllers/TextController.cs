﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VueQRCode.Controllers
{
    public class TextController : Controller
    {
        // GET: Text
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VueText()
        {
            return View();
        }
    }
}