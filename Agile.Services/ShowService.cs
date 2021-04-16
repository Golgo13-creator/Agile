using Agile.Data;
using Agile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.Services
{
    public class ShowService
    {
        private readonly Guid _userId;
        public ShowService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateShow(PostShow model)
        {
            var entity =
                new Show()
                {
                    Title = model.Title,
                    Description = model.Description
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Shows.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public GetShow GetShowByTitle(string title)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Shows
                        .Single(e => e.Title == title);
                return
                    new GetShow
                    {
                        ShowId = entity.ShowId,
                        Title = entity.Title,
                        Description = entity.Description,
                        Rating = entity.Rating,
                    };
            };
        }
    }
}
