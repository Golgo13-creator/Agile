using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agile.WebAPI.Controllers
{
    [System.Web.Authorize]
    public class ShowController : ApiController
    {
        private ShowService CreateShowService()
        {
            var userId = Guid.Parse(userId.Identity.GetUserId());
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
            ShowServie showService = CreateShowService();
            var shows = showService.GetShows();
            return Ok(shows);
        }
        //Get Show by Title
        public IHttpActionResult GetShowBytTitle(string title)
        {
            CreateShowService showService = CreateShowService();
            var show = showService.GetMovieByTitle(title);
            return Ok(title);

        }

    }
}