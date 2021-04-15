using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;


namespace Agile.WebAPI.Controllers
{
    [Authorize]
    public class MovieController : ApiController
    {
        private MovieService CreateMovieService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var movieService = new MovieService(userId);
            return movieService;
        }
        public IHttpActionResult Post(PostMovie movie)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateMovieService();
            if (!service.PostMovie(movie))
                return InternalServerError();
            return Ok();
        }
        //get all movies
        public IHttpActionResult Get()
        {
            MovieService movieService = CreateMovieService();
            var movies = movieService.GetMovies();
            return Ok(movies);
        }
        //Get(string title)
        public IHttpActionResult Get(string title)
        {
            MovieService movieService = CreateMovieService();
            var movie = movieService.GetMovieByTitle(title);
            return Ok(title);
        }
        //get movie by genre
        public IHttpActionResult Get(GenreType genre)
        {
            MovieService movieService = CreateMovieService();
            var movie = movieService.GetMovieByGenre(genre);
            return Ok(genre);
        }
    }
}