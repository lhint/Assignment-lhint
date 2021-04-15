using System;
using Microsoft.AspNetCore.Mvc;
using MMS.Web.Models;
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
            var tickets = mvc.GetMovieById(id);
            // pass tickets to view
            return View(tickets);
        }
       
        // POST /ticket/close/{id}
        [HttpPost]
        public IActionResult DeleteReview(int id)
        {   // close ticket via service

           var tickets = mvc.DeleteMovie(id);

            // redirect to the index view
            return RedirectToAction(nameof(Index));
        }
       
        // GET /ticket/create
        public IActionResult Create(int id)
        {
            // retrieve all students
            var movies = mvc.GetMovieById(id);
            
            // create a TicketViewModel and set the Students property
            var vm = new ReviewViewModel{
                // create the select list from the list of students and use the Id and Name
                // fields to populate the list
                // to new SelectList(students,"Id","Name")
                Reviews = new SelectList("Id","Comment","Title")
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
                var review = mvc.AddReview(rvm.MovieId, rvm.Comment);
                if (review != null) 
                {
                   return RedirectToAction("Index", new {Id = rvm.MovieId});
                }
            }            
            
            // redisplay the form for editing as validation failed 
            return View("Create", rvm);
        }
    }
}
