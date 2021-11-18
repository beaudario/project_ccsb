using Microsoft.AspNetCore.Mvc;
using project_ccsb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_ccsb.Controllers
{
    public class AfspraakController : Controller
    {
        private readonly IAfspraakService _afspraakService;

        public AfspraakController(IAfspraakService afspraakService)
        {
            _afspraakService = afspraakService;
        }
        public IActionResult Index()
        {
            ViewBag.KlantenList = _afspraakService.GetKlantList();

            return View();
        }
    }
}
