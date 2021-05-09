
using System;
using System.Linq;
using Xunit;

using MMS.Data.Models;
using MMS.Data.Services;

namespace MMS.Test
{
    public class TestMovieService
    {
        private readonly IMovieService mvc;
              
        public TestMovieService()
        {
            // create and initialise the service
            mvc = new MovieServiceDb();
            mvc.Initialise();     
        }

        // add tests here - test should ensure your service implementation fully works
        [Fact] 
        public void Movie_GetMovieWhenNone_ShouldReturnNone()
        {
            // arrange
            
            // act
            var movies = mvc.GetAllMovies();
            var count = movies.Count;

            // assert
            Assert.Equal(0, count);
        }

        [Fact]
        public void Movie_AddMovieWhenUnique_ShouldSetAllProperties()
        {
            // arrange

            // act
            var m1 = new Movie();
            m1.Title = "The Simpsons Movie";
            m1.Director = "David Silverman";
            m1.Year =  2007;
            m1.Duration = 87;
            m1.Budget = 75000000.00;
            m1.PosterUrl = "http://1.bp.blogspot.com/-9q82Ofdthj4/ULOEk_Md9qI/AAAAAAAAACU/J7HskH0PZjk/s1600/simpsons+poster.jpg";
            m1.Genre = Genre.Comedy;
            m1.Cast = "Dan Castellaneta, Julie Kavner, Nancy Cartwright, Yeardley Smith, Hank Azaria";
            m1.Plot = "After Homer pollutes the town's water supply, Springfield is encased in a gigantic dome by the EPA and the Simpsons are declared fugitives."; 
            mvc.AddMovie(m1);

            var movie = mvc.GetMovieById(m1.Id);

            // assert
            Assert.NotNull(movie);
            Assert.Equal(movie.Id, movie.Id);
            Assert.Equal("The Simpsons Movie", movie.Title);
            Assert.Equal("David Silverman", movie.Director);
            Assert.Equal(2007, movie.Year);
            Assert.Equal(87, movie.Duration);
            Assert.Equal(75000000.00, movie.Budget);
            Assert.Equal("http://1.bp.blogspot.com/-9q82Ofdthj4/ULOEk_Md9qI/AAAAAAAAACU/J7HskH0PZjk/s1600/simpsons+poster.jpg", movie.PosterUrl);
            Assert.Equal(Genre.Comedy, movie.Genre);
            Assert.Equal("Dan Castellaneta, Julie Kavner, Nancy Cartwright, Yeardley Smith, Hank Azaria", movie.Cast);
            Assert.Equal("After Homer pollutes the town's water supply, Springfield is encased in a gigantic dome by the EPA and the Simpsons are declared fugitives.", movie.Plot);
        }

        [Fact]
        public void Movie_UpdateWhenExists_ShouldSetAllProperties()
        {
            // arrange
            var m1 = new Movie();
            m1.Title = "The Simpsons Movie";
            m1.Director = "David Silverman";
            m1.Year = 2007;
            m1.Duration = 87;
            m1.Budget = 75000000.00;
            m1.PosterUrl = "http://1.bp.blogspot.com/-9q82Ofdthj4/ULOEk_Md9qI/AAAAAAAAACU/J7HskH0PZjk/s1600/simpsons+poster.jpg";
            m1.Genre = Genre.Comedy;
            m1.Cast = "Dan Castellaneta, Julie Kavner, Nancy Cartwright, Yeardley Smith, Hank Azaria";
            m1.Plot = "After Homer pollutes the town's water supply, Springfield is encased in a gigantic dome by the EPA and the Simpsons are declared fugitives."; 
            mvc.AddMovie(m1);

            // act

            m1.Title = "Test Movie";
            m1.Director = "Luke Hinton";
            m1.Year = 2000;
            m1.Duration = 2;
            m1.Budget = 70;
            m1.PosterUrl = "http://www.google.co.uk";
            m1.Genre = Genre.Action;
            m1.Cast = "Testing";
            m1.Plot = "This is test data";
            mvc.UpdateMovie(m1);

            // assert

            Assert.NotNull(m1);
            Assert.Equal("Test Movie", m1.Title);
            Assert.Equal("Luke Hinton", m1.Director);
            Assert.Equal(2000, m1.Year);
            Assert.Equal(2, m1.Duration);
            Assert.Equal(70, m1.Budget);
            Assert.Equal("http://www.google.co.uk", m1.PosterUrl);
            Assert.Equal(Genre.Action, m1.Genre);
            Assert.Equal("Testing", m1.Cast);
            Assert.Equal("This is test data", m1.Plot);

        }

        [Fact]
        public void Movie_GetMovieWhenTwoAdded_ShouldReturnTwo()
        {
            // arrange
            var m1 = new Movie();
            m1.Title = "The Simpsons Movie";
            m1.Director = "David Silverman";
            m1.Year = 2007;
            m1.Duration = 87;
            m1.Budget = 75000000.00;
            m1.PosterUrl = "http://1.bp.blogspot.com/-9q82Ofdthj4/ULOEk_Md9qI/AAAAAAAAACU/J7HskH0PZjk/s1600/simpsons+poster.jpg";
            m1.Genre = Genre.Comedy;
            m1.Cast = "Dan Castellaneta, Julie Kavner, Nancy Cartwright, Yeardley Smith, Hank Azaria";
            m1.Plot = "After Homer pollutes the town's water supply, Springfield is encased in a gigantic dome by the EPA and the Simpsons are declared fugitives."; 
            mvc.AddMovie(m1);

            var m2 = new Movie();
            m2.Id = 2;
            m2.Title = "Once";
            m2.Director = "John Carney";
            m2.Year = 2007;
            m2.Duration = 86;
            m2.Budget = 150000.00;
            m2.PosterUrl = "https://images-na.ssl-images-amazon.com/images/I/51TxjLxnlHL.jpg";
            m2.Genre = Genre.Drama;
            m2.Cast = "Glen Hansard, Markéta Irglová, 	Hugh Walsh, Gerard Hendrick, Alaistair Foley, Geoff Minogue, Bill Hodnett";
            m2.Plot = "An unnamed guy is a Dublin guitarist/singer/songwriter who makes a living by fixing vacuum cleaners in his Dad's Hoover repair shop by day, and singing and playing for money on the Dublin streets by night. An unnamed girl is a Czech who plays piano when she gets a chance, and does odd jobs by day and takes care of her Mom and her daughter by night. Guy meets girl and they get to know each other as the girl helps the guy put together a demo disc that he can take to London in hope of landing a music contract. During the same several day period, the guy and the girl work through their past loves, and reveal their budding love for one another, through their songs.";
            mvc.AddMovie(m2);

            // act
            var movies = mvc.GetAllMovies();
            var count = movies.Count;

            // assert
            Assert.Equal(2, count);
        }

        [Fact] 
        public void Movie_GetMovieWhenNone_ShouldReturnNull()
        {
            // arrange

            // act 
            var movie = mvc.GetMovieById(1); // non existent student

            // assert
            Assert.Null(movie);
        }

        [Fact]
        public void Movie_GetMovieThatExists_ShouldReturnStudent()
        {
            // arrange
            var m1 = new Movie();
            m1.Title = "The Simpsons Movie";
            m1.Director = "David Silverman";
            m1.Year = 2007;
            m1.Duration = 87;
            m1.Budget = 75000000.00;
            m1.PosterUrl = "http://1.bp.blogspot.com/-9q82Ofdthj4/ULOEk_Md9qI/AAAAAAAAACU/J7HskH0PZjk/s1600/simpsons+poster.jpg";
            m1.Genre = Genre.Comedy;
            m1.Cast = "Dan Castellaneta, Julie Kavner, Nancy Cartwright, Yeardley Smith, Hank Azaria";
            m1.Plot = "After Homer pollutes the town's water supply, Springfield is encased in a gigantic dome by the EPA and the Simpsons are declared fugitives."; 
            mvc.AddMovie(m1);

            // act
            var movie = mvc.GetMovieById(m1.Id);

            // assert
            Assert.NotNull(movie);
            Assert.Equal(m1.Id, movie.Id);
        }

        [Fact]
        public void Movie_DeleteMovieThatExists_ShouldReturnTrue()
        {
            // arrange
            var m1 = new Movie();
            m1.Title = "The Simpsons Movie";
            m1.Director = "David Silverman";
            m1.Year = 2007;
            m1.Duration = 87;
            m1.Budget = 75000000.00;
            m1.PosterUrl = "http://1.bp.blogspot.com/-9q82Ofdthj4/ULOEk_Md9qI/AAAAAAAAACU/J7HskH0PZjk/s1600/simpsons+poster.jpg";
            m1.Genre = Genre.Comedy;
            m1.Cast = "Dan Castellaneta, Julie Kavner, Nancy Cartwright, Yeardley Smith, Hank Azaria";
            m1.Plot = "After Homer pollutes the town's water supply, Springfield is encased in a gigantic dome by the EPA and the Simpsons are declared fugitives."; 
            mvc.AddMovie(m1);

            // act
            var deleted = mvc.DeleteMovie(m1.Id);
            var movie = mvc.GetMovieById(m1.Id);

            // assert
            Assert.True(deleted);
            Assert.Null(movie);
        }

        [Fact]
        public void Movie_DeleteMovieThatExists_ShouldReduceStudentCountByOne()
        {
            // arrange
            var m1 = new Movie();
            m1.Title = "The Simpsons Movie";
            m1.Director = "David Silverman";
            m1.Year = 2007;
            m1.Duration = 87;
            m1.Budget = 75000000.00;
            m1.PosterUrl = "http://1.bp.blogspot.com/-9q82Ofdthj4/ULOEk_Md9qI/AAAAAAAAACU/J7HskH0PZjk/s1600/simpsons+poster.jpg";
            m1.Genre = Genre.Comedy;
            m1.Cast = "Dan Castellaneta, Julie Kavner, Nancy Cartwright, Yeardley Smith, Hank Azaria";
            m1.Plot = "After Homer pollutes the town's water supply, Springfield is encased in a gigantic dome by the EPA and the Simpsons are declared fugitives."; 
            mvc.AddMovie(m1);

            // act
            var deleted = mvc.DeleteMovie(m1.Id);
            var movie = mvc.GetAllMovies();

            // assert
            Assert.Equal(0,movie.Count);
        }
    }
}
