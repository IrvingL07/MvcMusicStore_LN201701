﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore_LN201701.Models;
//using MvcMusicStore_LN201701.Models.Album;


namespace MvcMusicStore_LN201701.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        public string Index()
        {
            return "Hello from Store.Index()";
        }
        //
        // GET: /Store/Browse?genre=Disco
        public ActionResult Browse(string genre)
        {
            var genreModel = new Genero { Name = genre };
            return View(genreModel);
        }
        //
        // GET: /Store/Details
        public ActionResult Details (int id)
        {
            var album = new Album { Title = "Album" + id };
            return View(album);
        }
    }
}