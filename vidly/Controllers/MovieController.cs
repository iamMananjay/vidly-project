using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModel;


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

        //passing data to the view in three way 
        public ActionResult Random()
        {
            var Movie = new Movie
            {
                Id = 1,
                Name = "Mananjay"
            };


            //first approach
            return View(Movie);

            //second approach view bag
            //ViewBag.UserMovie = Movie;
            //return View(); 

            // third approach view data dictionary
            //ViewData["Movie"] = Movie;
            //return View();
        }

        public ActionResult MovieList()
        {
            //Make a object of Movie Model
            var Movie = new Movie { Name = "Lord of ring" };
            //Make a object of customer model in form of list

            var Customer = new List<Customer>
            {
                new Customer { CustomerName="Alina Heka"},
                new Customer {CustomerName = "Mananjay shrestha"}
            };


            //Make a object of Moviecustomerviewmodel and pass both model inside the property of viewmodel

            var MovieCustomerViewModel = new MovieCustomerViewModel
            {
                Movie = Movie,
            Customer = Customer
            };
            //pass a view model
            return View(MovieCustomerViewModel);
        }



    }
}