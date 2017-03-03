using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApplication.Models;

namespace MVCApplication.Controllers
{
    public class MovieTypeController : Controller
    {
        // GET: MovieType
        public ActionResult Index()
        {
            MVCTest mvc = new MVCTest();
            List<MovieType> m = mvc.movietype.ToList();

            return View(m);
        }
    }
}