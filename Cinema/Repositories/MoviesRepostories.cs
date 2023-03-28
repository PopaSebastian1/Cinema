using Cinema.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;

namespace Cinema.Repositories
{
    public class MoviesRepostories
    {
        private readonly MovieContext movieContext;

        public MoviesRepostories(MovieContext movieContext)
        {
            this.movieContext = movieContext;
        }

        public List<Movie> GetAll()
        {
            return movieContext.Movies.ToList();
        }

        public Movie GetById(int id)
        {
            return movieContext.Movies.Where(x => x.Id == id).FirstOrDefault();

        }
        public void AddMovie(Movie movie)
        {
            if (movie == null)
            {
                throw new ArgumentNullException(nameof(movie));
            }

            var newMovie = new Movie
            {
                Title = movie.Title,
                Description = movie.Description,
                Director = movie.Director,
                Rating = movie.Rating
            };

            movieContext.Movies.Add(newMovie);
            movieContext.SaveChanges();
        }
        public void UpdateMovieTitle(int id, string newTitle)
        {
            var movieToUpdate = movieContext.Movies.FirstOrDefault(m => m.Id == id);
            if (movieToUpdate == null)
            {
                throw new ArgumentException("Movie not found");
            }
            movieToUpdate.Title = newTitle;
            movieContext.SaveChanges();
        }
        public void DeleteMovie(int id)
        {
          var movie = movieContext.Movies.FirstOrDefault(x => x.Id == id);
            movieContext.Movies.Remove(movie);
            movieContext.SaveChanges();
        }
    }
}
