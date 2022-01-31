using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using BookRecomendationBusinessLayer;
using BookRecomendationDTO;
using BookRecomendationWebApp.Models;
using Newtonsoft.Json;

namespace BookRecomendationWebApp.Controllers
{
    //DO NOT MODIFY THE METHOD NAMES : Adding of parameters / changing the return types of the given methods may be required.
    public class RecomendBookController : Controller
    {
        // GET: RecomendBook
        BookRecomendationBL blobj;
        public ActionResult Index()
        {
            return View();
        }



        public ViewResult AddReviews()
        {
            try
            {
                return View();

            }
            catch(Exception ex)
            {
                return View("Error");
            }

        }

        public void DisplayResultsUsingWebAPI()
        {
        }
    }
}