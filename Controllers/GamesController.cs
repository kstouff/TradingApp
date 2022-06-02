using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TradingApp.Models;

namespace TradingApp.Controllers
{
    public class GamesController : Controller
    {
        private TradingAppContext db;

        public GamesController(TradingAppContext context)
        {
            db = context;
        }

        [HttpGet("/games")]
        public IActionResult All()
        {
            return View("All");
        }

        
    }
}