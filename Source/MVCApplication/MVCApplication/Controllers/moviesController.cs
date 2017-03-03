using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApplication.Models;

namespace MVCApplication.Controllers
{
    public class moviesController : Controller
    {
        // GET: movies
        public ActionResult Contact1(int id)
        {
            MVCTest mvctest = new MVCTest();
            List<movie> m = mvctest.Movie.Where(emp => emp.MovieTypeID == id).ToList();
            return View(m);
        }
        public ActionResult Random(int id)
        {
            MVCTest mvctest = new MVCTest();
            movie m = mvctest.Movie.Single(movieid=>movieid.MovieId==id);
            return View(m);
        }

        [Route("movie/release/{year}/{month}")]
        public ActionResult ByReleaseYear(int year,int month)
        {
            return Content(year+"/"+month);
        }

       
    }
}