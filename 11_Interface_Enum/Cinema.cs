using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Interface_Enum
{
    internal class Cinema : IEnumerable<Movie>
    {
        private List<Movie> movies = new List<Movie>();
        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }
        public void RemoveMovie(Movie movie)
        {
            movies.Remove(movie);
        }
        public IEnumerator<Movie> GetEnumerator()
        {
            return movies.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void SortMovies(IComparer<Movie> comparer)
        {
            movies.Sort(comparer);
        }

        public override string ToString()
        {
            if (movies.Count == 0)
                return "Кінотеатр не містить жодного фільму.";

            return string.Join(Environment.NewLine, movies.Select(m => m.ToString()));
        }

    }

}
