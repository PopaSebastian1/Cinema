using Cinema.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieContext movieContext;   
        public MovieController(MovieContext movieContext)
        {
            this.movieContext = movieContext;
        }
        [HttpGet("/get")]
        public string Get()
        {
            return "Hello World";
        }
    }
}
