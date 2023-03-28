using Cinema.Entities;
using Cinema.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
    private  MovieService movieService { get; set; }
        public MovieController(MovieService movieService)
        {
            this.movieService = movieService;
        }
        [HttpGet("/get-all")]
       public ActionResult<List<Movie>>GetAll()
        {
            var result = movieService.GetAll();
            return Ok(result);
        }
        [HttpGet("/get-by-id")]
        public ActionResult<Movie> GetById(int id)
        {
            var result= movieService.GetById(id);
            if(result == null)
            {
                return BadRequest("Movie not found");
            }
            return Ok(result);
        }
        [HttpPost("/addMovie")]
        public void Add(Movie movie)
        {
          movieService.Add(movie);

        }
        [HttpPost("/update")]
        public void Update(Movie movie)
        {
            movieService.Update(movie);
        }
        [HttpPost("/delete")]
        public void Delete(int id)
        {
            movieService.Delete(id);
        }
    }
}
