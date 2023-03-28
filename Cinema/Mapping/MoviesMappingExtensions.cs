using Cinema.DTO;
using Cinema.Entities;
using System.Runtime.CompilerServices;

namespace Cinema.Mapping
{
    public static class MoviesMappingExtensions
    {
        public static MovieDTO ToMovieDto(this Movie movie)
        {
            if(movie==null)
            {
                return null;
            }
            var result=new MovieDTO();
            result.Title = movie.Title;
            result.Director = movie.Director;
            result.Rating = movie.Rating;
            return result;
        }

    }
}
