using MvcMusicStore_LN201701.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore_LN201701.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var genres = new List<Genero>
            {
                new Genero { Name = "Disco"},
                new Genero { Name = "Jazz"},
                new Genero { Name = "Rock"}
            };
            return View(genres);
        }
    }
}