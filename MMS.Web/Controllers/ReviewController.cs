using System;
using Microsoft.AspNetCore.Mvc;
using MMS.Web.Models;
using MMS.Data.Models;
using MMS.Data.Services;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SMS.Web.Controllers
{
    public class ReviewController : BaseController
    {
        private readonly IMovieService mvc;
        
        public ReviewController()
        {
            mvc = new MovieServiceDb();
        }

        // GET /review/index
        public IActionResult Index(int id)
        {
            // get review by Id
            var reviews = mvc.GetReviewById(id);
            // pass review to view
            return View(reviews);
        }
       
        // GET /review/create
        public IActionResult Create()
        {
            // retrieve all movies
            var movies = mvc.GetAllMovies();
            
            // create a ReviewViewModel and set the movies property
            var vm = new ReviewViewModel{
                // create the select list from the list of movies and use the Id and Name
                // fields to populate the list
                // to new SelectList(movies,"Id","Title")
                Movies = new SelectList(movies,"Id", "Title")
            };
            // now display the view and pass the newly created viewmodel
            // render blank form
            return View(vm);
        }
       
        // POST /review/create
        [HttpPost]
        public IActionResult Create(ReviewViewModel rvm)
        {
            // if reviewviewmodel is valid
                // create review
                // redirect to Index

            if (ModelState.IsValid)
            {
                var review = new Review();
                review.MovieId = rvm.MovieId;
                review.Name = rvm.Name;
                review.Comment = rvm.Comment;
                review.Rating = rvm.Rating;

                mvc.AddReview(review);
                Alert("Review added!",AlertType.success);

                return RedirectToAction(nameof(Index));
            }            
            
            // redisplay the form for editing as validation failed 
            return View(rvm);
        }
    }
}
