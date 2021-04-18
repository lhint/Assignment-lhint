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

        // GET /ticket/index
        public IActionResult Index(int id)
        {
            // get all open tickets
            var reviews = mvc.GetReviewById(id);
            // pass tickets to view
            return View(reviews);
        }
       
        // GET /ticket/create
        public IActionResult Create()
        {
            // retrieve all students
            var movies = mvc.GetAllMovies();
            
            // create a TicketViewModel and set the Students property
            var vm = new ReviewViewModel{
                // create the select list from the list of students and use the Id and Name
                // fields to populate the list
                // to new SelectList(students,"Id","Name")
                Movies = new SelectList(movies,"Id", "Title")
            };
            // now display the view and pass the newly created viewmodel
            // render blank form
            return View(vm);
        }
       
        // POST /ticket/create
        [HttpPost]
        public IActionResult Create(ReviewViewModel rvm)
        {
            // if ticketviewmodel is valid
                // create ticket
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
