using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;

using MMS.Data.Models;
using MMS.Data.Services;
using MMS.Web.Models;
using MMS.Data.Repositories;
using System.Linq;

namespace SMS.Web.Controllers
{
    public class MovieController : BaseController
    {
        private IMovieService mvc;

        public MovieController()
        {
            mvc = new MovieServiceDb();
        }

        private MovieDbContext db = new MovieDbContext();

        // GET /movie
        public IActionResult Index(string sortOrder)
        {
            //returns all movies to an index view
            //https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/sorting-filtering-and-paging-with-the-entity-framework-in-an-asp-net-mvc-application
            ViewBag.TitleSortParm = String.IsNullOrEmpty(sortOrder) ? "Title" : "";
            ViewBag.YearSortParm = sortOrder == "Year" ? "Year" : "Year";
            ViewBag.DirectorSortParm = sortOrder == "Director" ? "by_director" : "Director";
            var movie = from m in db.Movies
                        select m;
            switch (sortOrder)
            {
                case "Title":
                    movie = movie.OrderBy(m => m.Title);
                break;
                case "Year":
                movie = movie.OrderBy(m => m.Year);
                break;
                case "Director":
                movie = movie.OrderBy(m => m.Director);
                break;
                default:
                movie = movie.OrderBy(m => m.Title);
                break; 
            }
            return View(movie.ToList());
            //var movies = mvc.GetAllMovies();
           
            //return View(movies);
        }

        // GET /movies/details/{id}
        public IActionResult Details(int id)
        {
            // retrieve the movies with specified id from the service
            var m = mvc.GetMovieById(id);

            // check if m is null and return NotFound()
            if (m == null)
            {     
               Alert("Movie Was Not Found", AlertType.info);
               return RedirectToAction(nameof(Index));
            }

            // pass movie as parameter to the view
            return View(m);
        }

        // GET: /movie/create
        public IActionResult Create()
        {
            // display blank form to create a movie
            var m = new Movie();
            return View(m);
        }

        // POST /movie/create
        [HttpPost]
        public IActionResult Create(Movie m)
        {
            // check title is unique for this movie
            //if(svc.IsDuplicateTitle(m.Title, m.Id))
            var existing = mvc.GetMovieByTitle(m.Title); 
            if (existing != null)
            {
                ModelState.AddModelError(nameof(m.Title),"Movie with this title already exists");
            }

            // complete POST action to add movie
            if (ModelState.IsValid)
            {
                // pass data to service to store 
                mvc.AddMovie(m);
                Alert("Movie Was Created", AlertType.info);
               

                return RedirectToAction(nameof(Index));
            }
           
            // redisplay the form for editing as there are validation errors
            return View(m);
        }

        // GET /movie/edit/{id}
        public IActionResult Edit(int id) {
            var m = mvc.GetMovieById(id); // load the movie using the service            
            if (m == null)  {           // check if m is null and alert
                return NotFound();
            }
            return View(m); // pass movie to view for editing
        }

        // POST /movie/edit/{id}
        [HttpPost]
        public IActionResult Edit(int id, Movie s)
        {
            // check title is unique for this movie
            //if(svc.IsDuplicateTitle(s.Title, s.Id))
            //{
             // ModelState.AddModelError(nameof(s.Title),"The movie title is already in use");
            //}
            

            // complete POST action to save movie changes
            if (ModelState.IsValid)
            {
                // Pass data to service to update
                var updated = mvc.UpdateMovie(s);
                Alert("Movie updated", AlertType.info);
                return RedirectToAction(nameof(Index));     
            }
            // redisplay the form for editing as validation errors
            return View(s);
        }

        // GET / movie/delete/{id}
        public IActionResult Delete(int id)
        {
            // load the movie using the service
            var m = mvc.GetMovieById(id);
            // check the returned movie is not null and if so alert
            if (m == null)
            {
               return NotFound();
            }     
            
            // pass movie to view for deletion confirmation
            return View(m);
        }

        // POST /movie/delete/{id}
        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var m1 = mvc.GetMovieById(id);
            // delete student via service
            mvc.DeleteMovie(id);
            Alert($"Movie {m1.Id} Was Deleted", AlertType.warning);
         
            // redirect to the index view
            return RedirectToAction(nameof(Index));
        }

        // GET /movie/createreview
        public IActionResult CreateReview(int id, string comment, string title)
        {
            var s = mvc.GetMovieById(id);
             // check the returned movie is not null and if so alert
            if (s == null)
            {      
                Alert("Movie does not exist", AlertType.warning);
                return RedirectToAction(nameof(Index));
            }  
            // create the review view model and populate the MovieId property
            var review = new ReviewViewModel {
                MovieId = id
            };
 
            return View("CreateReview", review);
        }

        // POST /movie/createreview
        [HttpPost]
        public IActionResult CreateReview(Review r)
        {
            // retrieve movie using t.MovieId
            var m = mvc.GetMovieById(r.MovieId);

            if (m == null)
            {
                Alert("Movie not found", AlertType.warning);
                return RedirectToAction("Index");
            }
            // check the returned movie is not null and if so alert and 
            // redirect to Index view
            if (ModelState.IsValid)
            {
                var review = new Review {
                    MovieId = r.MovieId,
                    Name = r.Name,
                    Rating = r.Rating,
                    Comment = r.Comment,
                };

            mvc.AddReview(review);
            Alert("Review Was Created", AlertType.info);
            // redirect to Details view passing route parameter- new {Id = t.StudentId}
            return RedirectToAction(nameof(Details), new { Id = r.Id } );
            // redisplay the form for editing
            }
            return View("CreateReview",r);
        }

        //Delete Review

            public IActionResult RemoveReview(int id)
            {  

            var s = mvc.GetReviewById(id);
             // check the returned movie is not null and if so alert
            if (s == null)
            {      
                Alert("Error deleting review", AlertType.warning);
                return RedirectToAction(nameof(Index));
            }  
            // create the review view model and populate the MovieId property
            mvc.DeleteReview(id);

            Alert("Review Deleted", AlertType.success);
            //return RedirectToAction(nameof(Details));
            return RedirectToAction(nameof(Details), new { Id = id });
        }
    }
}