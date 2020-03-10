using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Senai.Senatur.WebApi.Controllers
{
    public class PacotesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}