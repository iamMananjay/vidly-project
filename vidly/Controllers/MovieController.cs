using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;


namespace vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie

        //routing attribute
        [Route("Movie/Index/{year}/{month:regex(\\d{2})}")]
        public ActionResult Index(int year, string month)
        {
            return Content("Hello world" + year + month);
        }

        //default routing
        public ActionResult Randomaction(int year, string month)
        {
            return Content("Hello world" + year + month);
        }

        public ActionResult Random()
        {
            var Movie = new Movie
            {
                Id=1,
                Name = "Mananjay"
            };
            return View(Movie);        
        }


    }
}