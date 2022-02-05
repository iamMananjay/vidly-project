using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidly.Models;

namespace vidly.ViewModel
{
    public class MovieCustomerViewModel
    {
        public Movie Movie { get; set; }

        public List<Customer> Customer { get; set; }
    }
}