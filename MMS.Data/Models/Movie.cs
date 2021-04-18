using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

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
        [Required]
        public string Title { get; set; }

        // name of movie director(s)
        [Required]
        public string Director { get; set; }     
        
        // year movie was released (integer)
        [Required]
        public int Year { get; set; }

        // duration of the movie in minutes
        [Required]
        public int Duration { get; set; }   

        // budget of movie in millions        
        public double Budget { get; set; }

        // url of a valid poster resource
        // see https://www.themoviedb.org for poster images
        [Required]
        public string PosterUrl { get; set; } 

        // a genre for the movie (uses the Genre enumeration)        
        public Genre Genre { get; set; }

        // names of the cast members
        [Required]
        public string Cast { get; set; }

        // the general movie plot (up to approx 5000 chars)
        [Required]
        [StringLength(500)]
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