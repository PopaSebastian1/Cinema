using Cinema.DTO;
using Cinema.Entities;
using Cinema.Mapping;
using Cinema.Repositories;

namespace Cinema.Services
{
    public class MovieService
    {
        private  MoviesRepostories moviesRepostories   { get; set; } 
        public MovieService(MoviesRepostories moviesRepostories)
        {
            this.moviesRepostories = moviesRepostories;
        }
        public List<Movie> GetAll()
        {
            var results= moviesRepostories.GetAll();
            return results;
        }
        public MovieDTO GetById(int id)
        {
            var movie = moviesRepostories.GetById(id);
            var result = movie.ToMovieDto();
            return result;
        }
        public void Add(Movie movie)
        {
            moviesRepostories.AddMovie(movie);
        }
        public void Update(Movie movie)
        {
            moviesRepostories.UpdateMovieTitle(movie.Id, movie.Title);
        }
        public void Delete(int id)
        {
            moviesRepostories.DeleteMovie(id);
        }
    }
}
