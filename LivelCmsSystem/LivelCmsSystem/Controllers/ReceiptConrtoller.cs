﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LivelCmsSystem.Controllers
{
    public class ReceiptConrtoller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
