using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Interface_Enum
{
    public enum Genre
    {
        Action,
        Comedy,
        Drama,
        Horror,
        SciFi,
        Documentary,
        Romance

    }
    public class Movie: ICloneable, IComparable<Movie>
    {
        public string Title {  get; set; }
        public string Description { get; set; }
        public Director Director { get; set; }
        public string Country { get; set; }
        public  Genre Genre { get; set; }
        public int Year {  get; set; }
        public double Rating { get; set; }

        public int CompareTo(Movie? other)
        {
            if (other == null) return 1; 
            return string.Compare(this.Title, other.Title, StringComparison.OrdinalIgnoreCase);
        }
        public object Clone()
        {
            return new Movie
            {
                Title = this.Title,
                Description = this.Description,
                Director = (Director)this.Director.Clone(),
                Country = this.Country,
                Genre = this.Genre,
                Year = this.Year,
                Rating = this.Rating
            };
        }

        public override string ToString()
        {
            return $"{Title} ({Year}) - {Genre}\n" +
                   $"Director: {Director}\n" +
                   $"Country: {Country}\n" +
                   $"Rating: {Rating}\n" +
                   $"Description: {Description}";
        }

    }

    public class RatingComparer : IComparer<Movie>
    {
        public int Compare(Movie x, Movie y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;
            
            return y.Rating.CompareTo(x.Rating);
        }

        public class YearComparer : IComparer<Movie>
        {
            public int Compare(Movie x, Movie y)
            {
                return x.Year.CompareTo(y.Year);
            }
        }
    }


}
