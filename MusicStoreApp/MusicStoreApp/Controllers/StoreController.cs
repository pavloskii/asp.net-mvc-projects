﻿using MusicStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStoreApp.Controllers
{
    public class StoreController : Controller
    {
        // GET: /Home
        public ActionResult Index()
        {
            var genres = new List<Genre>
            {
                new Genre { Name = "Disco"},
                new Genre { Name = "Jazz"},
                new Genre { Name = "Rock"},
            };

            return View(genres);
        }

        // GET: Store/Browse?genre=Disco
        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre { Name = genre };

            return View(genreModel);
        }

        //GET: /Store/Details/5
        public ActionResult Details(int id)
        {
            var album = new Album { Title = "Album" + id };

            return View(album);
        }

    }
}