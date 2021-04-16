using Agile.Models;
using Agile.Data;
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
    public class ShowController : ApiController
    {
        private ShowService CreateShowService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var showService = new ShowService(userId);
            return showService;
        }

        public IHttpActionResult Post(PostShow show)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateShowService();
            if (!service.CreateShow(show))
                return InternalServerError();
            return Ok();
        }
        //Get all Shows
        public IHttpActionResult GetAllShows()
        {
            ShowService showService = CreateShowService();
            var shows = showService.GetShows();
            return Ok(shows);
        }
        //Get Show by Title
        public IHttpActionResult GetShowBytTitle(string title)
        {
            ShowService showService = CreateShowService();
            var show = showService.GetShowByTitle(title);
            return Ok(title);

        }

        public IHttpActionResult Get(GenreType genre)
        {
            ShowService showService = CreateShowService();
            var show = showService.GetShowByGenre((Data.ShowGenre)genre);
            return Ok(genre);
        }

    }
}