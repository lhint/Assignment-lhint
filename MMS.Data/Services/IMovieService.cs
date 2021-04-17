using System;
using System.Collections.Generic;
using MMS.Data.Models;

namespace MMS.Data.Services
{
    public interface IMovieService
    {
        void Initialise();
        IList<Movie> GetAllMovies(string order=null);
        Movie GetMovieById(int id);
        Movie GetMovieByTitle(string title);
        bool DeleteMovie(int id);
        bool UpdateMovie(Movie m);
        Movie AddMovie(Movie m);
        Review GetReviewById(int id);
        Review AddReview(Review r);
        bool DeleteReview(int id);
    }
}