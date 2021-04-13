using System;
using System.Text;
using System.Collections.Generic;
using MMS.Data.Models;

namespace MMS.Data.Services
{
    public static class ServiceSeeder
    {
        public static void Seed(IMovieService mvc)
        {
            mvc.Initialise();

            //add movie
            var m1 = new Movie();
            m1.Id = 1;
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

            var m3 = new Movie();
            m3.Id = 3;
            m3.Title = "Saving Private Ryan";
            m3.Director = "Steven Spielberg";
            m3.Year = 1998;
            m3.Duration = 169;
            m3.Budget = 70000000.00;
            m3.PosterUrl = "https://images-na.ssl-images-amazon.com/images/I/917O7ZZeoXL._AC_SX466_.jpg";
            m3.Cast = "Tom Hanks, Tom Sizemore, Edward Burns, Barry Pepper, Adam Goldberg, Vin Diesel, Giovanni Ribisi, Jeremy Davies, Matt Damon";
            m3.Plot ="Opening with the Allied invasion of Normandy on 6 June 1944, members of the 2nd Ranger Battalion under Cpt. Miller fight ashore to secure a beachhead. Amidst the fighting, two brothers are killed in action. Earlier in New Guinea, a third brother is KIA. Their mother, Mrs. Ryan, is to receive all three of the grave telegrams on the same day. The United States Army Chief of Staff, George C. Marshall, is given an opportunity to alleviate some of her grief when he learns of a fourth brother, Private James Ryan, and decides to send out 8 men (Cpt. Miller and select members from 2nd Rangers) to find him and bring him back home to his mother...";
            mvc.AddMovie(m3);

            var m4 = new Movie();
            m4.Id = 4;
            m4.Title = "Avengers Endgame";
            m4.Director = "Anthony Russo, Joe Russo";
            m4.Year = 2019;
            m4.Duration = 181;
            m4.Budget = 356000000.00;
            m4.PosterUrl = "https://lumiere-a.akamaihd.net/v1/images/p_avengersendgame_19751_e14a0104.jpeg?region=0%2C0%2C540%2C810";
            m4.Cast = "Robert Downey Jr., Chris Evans, Mark Ruffalo, Chris Hemsworth, Scarlett Johansson, Jeremy Renner, Don Cheadle, Paul Rudd, Benedict Cumberbatch";
            m4.Plot = "After the devastating events of Avengers: Infinity War (2018), the universe is in ruins. With the help of remaining allies, the Avengers assemble once more in order to reverse Thanos' actions and restore balance to the universe.";
            mvc.AddMovie(m4);

            var m5 = new Movie();
            m5.Id = 5;
            m5.Title = "Avatar";
            m5.Director = "James Cameron";
            m5.Year = 2009;
            m5.Duration = 162;
            m5.Budget = 237000000.00;
            m5.PosterUrl = "https://images-na.ssl-images-amazon.com/images/I/91nWAnC73oS._AC_SY445_.jpg";
            m5.Cast = "Sam Worthington, Zoe Saldana, Sigourney Weaver, Stephen Lang, Michelle Rodriguez, Giovanni Ribisi, Joel David Moore, CCH Pounder, Wes Studi";
            m5.Plot = "A paraplegic Marine dispatched to the moon Pandora on a unique mission becomes torn between following his orders and protecting the world he feels is his home.";
            mvc.AddMovie(m5);

            //add review
            
        }
    }
}