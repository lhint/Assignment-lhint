using System.Collections.Generic;
using System.Linq;

namespace MMS.Data.Models
{
    public enum Genre
    {
        Action, Comedy, Family, Horror, Romance, SciFi, Thriller, Western, War, Drama
    }
    
    public class Movie
    {
                
        public int Id { get; set; }
        
        // name of movie
        public string Title { get; set; }

        // name of movie director(s)
        public string Director { get; set; }     
        
        // year movie was released (integer)
        public int Year { get; set; }

        // duration of the movie in minutes
        public int Duration { get; set; }   

        // budget of movie in millions        
        public double Budget { get; set; }

        // url of a valid poster resource
        // see https://www.themoviedb.org for poster images
        public string PosterUrl { get; set; } 

        // a genre for the movie (uses the Genre enumeration)        
        public Genre Genre { get; set; }

        // names of the cast members
        public string Cast { get; set; }

        // the general movie plot (up to approx 500 chars)
        public string Plot { get; set; }
        
        // ReadOnly Property - Calculates Rating % based on average of all reviews
        public int Rating
        {
            get
            {
                var count = Reviews.Count > 0 ? Reviews.Count : 1;
                return Reviews.AsEnumerable().Sum(r => r.Rating) / count * 10;
            }
        }

        // EF Relationship - a movie can have many reviews 
        public IList<Review> Reviews { get; set; } = new List<Review>();

    }
}