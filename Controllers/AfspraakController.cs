using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_ccsb.Controllers
{
    public class AfspraakController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
