using Agile.Data;
using Agile.Models;
using Agile.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;


namespace Agile.WebAPI.Controllers
{
    [System.Web.Http.Authorize]
    public class MovieController : ApiController
    {
        private MovieServices CreateMovieService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var movieService = new MovieServices(userId);
            return movieService;
        }
        public IHttpActionResult Post(PostMovie movie)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateMovieService();
            if (!service.CreateMovie(movie))
                return InternalServerError();
            return Ok();
        }
        //get all movies
        public IHttpActionResult Get()
        {
            MovieServices movieService = CreateMovieService();
            var movies = movieService.GetMovies();
            return Ok(movies);
        }
        //Get(string title)
        public IHttpActionResult Get(string title)
        {
            MovieServices movieService = CreateMovieService();
            var movie = movieService.GetMovieByTitle(title);
            return Ok(title);
        }
        //get movie by genre
        public IHttpActionResult Get(GenreType genre)
        {
            MovieServices movieService = CreateMovieService();
            var movie = movieService.GetMovieByGenre((Data.GenreType)genre);
            return Ok(genre);
        }
    }
}