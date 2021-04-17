using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

using MMS.Data.Models;
using MMS.Data.Repositories;

namespace MMS.Data.Services
{
    // create IMovieService implementation called MovieServiceDb
    // using the provided Entityframework Repository (MovieDbContext)
    public class MovieServiceDb : IMovieService
    {
        private readonly MovieDbContext db;

        public MovieServiceDb()
        {
            db = new MovieDbContext();
        }
        public void Initialise()
        {
            db.Initialise();
        }

        //movie operations

        public IList<Movie> GetAllMovies(string order)
        {
            return db.Movies.ToList();
        }
        public Movie GetMovieById(int id)
        {
            return db.Movies.Include(s => s.Reviews)
                            .FirstOrDefault(s => s.Id == id);
        }

        public Movie GetMovieByTitle(string title)
        {
            return db.Movies.FirstOrDefault(m => m.Title == title);
        }

        public bool DeleteMovie(int id)
        {
            var m = GetMovieById(id);
            if (m == null)
            {
                return false;
            }
            db.Movies.Remove(m);
            db.SaveChanges();
            return true;
        }

        public bool UpdateMovie(Movie updated)
        {
            var m  = GetMovieById(updated.Id);
            if (m == null)
            {
                return false;
            }
            m.Id = updated.Id;
            m.Title = updated.Title;
            m.Director = updated.Director;
            m.Year = updated.Year;
            m.Duration = updated.Duration;
            m.Budget = updated.Budget;
            m.PosterUrl = updated.PosterUrl;
            m.Genre = updated.Genre;
            m.Plot = updated.Plot;

            db.SaveChanges();
            return true;
        }

        public Movie AddMovie(Movie m)
        {
            var existing = GetMovieByTitle(m.Title); 
            if (existing != null)
            {
                return null;
            }

            db.Movies.Add(m);
            db.SaveChanges();
            return m;
        }

        //review operations

        public Review GetReviewById(int id)
        {
            var review = db.Movies.SelectMany(r => r.Reviews).FirstOrDefault(r => r.Id == id);
            return review;
        }

        public Review AddReview(Review r)
        {
            var m = GetMovieById(r.MovieId);
            if (m == null) return null;

            var review = new Review
            {
                //Id automaticly created
                Name = r.Name,
                MovieId = r.MovieId,
                Comment = r.Comment,
                CreatedOn = DateTime.Now,
                Rating = r.Rating
            };
            m.Reviews.Add(review);
            db.SaveChanges();
            
            return review;
        }

        public bool DeleteReview(int id)
        {
            //find review
            var review = GetReviewById(id);
            if (review == null) return false;

            //remove review
            var result = review.Movie.Reviews.Remove(review);
            db.SaveChanges();

            return true;
        }
    }
}