using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class FrancescaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}