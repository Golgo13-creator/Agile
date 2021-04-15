//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Agile.Models;

//namespace Agile.Services
//{
//    public class MovieServices
//    {
//        private readonly Guid _userId;
//        public MovieServices(Guid userId)
//        {
//            _userId = userId;
//        }
//        public bool CreateMovie(PostMovie model)
//        {
//            var entity =
//                new Movie()
//                {
//                    OwnerId = _userId,
//                    Title = model.Title,
//                    Description = model.Description,
//                    Genre = model.Genre,
//                    AverageRating = model.AverageRating
//                };
//            using (var ctx = new ApplicationDbContext())
//            {
//                ctx.Movies.Add(entity);
//                return ctx.SaveChanges() == 1;
//            }
//        }
//        public IEnumerable<MovieListItem> GetMovies()
//        {
//            using (var ctx = new ApplicationDbContext())
//            {
//                var query =
//                    ctx
//                        .Movies
//                        .Where(e => e.OwnerId == _userId)//adjustment may be needed
//                        .Select(
//                            e =>
//                                new MovieListItem
//                                {
//                                    MovieId = e.MovieId,
//                                    Title = e.Title,
//                                    Description = e.Description,
//                                    Genre = e.Genre,
//                                    AverageRating = e.AverageRating
//                                }
//                         );
//                return query.ToArray();
//            }
//        }
//        //Get movie by title service method
//        public GetMovie GetMovieByTitle(string title)
//        {
//            using (var ctx = new ApplicationDbContext())
//            {
//                var entity =
//                    ctx
//                        .Movies
//                        .Single(e => e.Title == title);
//                return
//                    new GetMovie
//                    {
//                        MovieId = entity.MovieId,
//                        Title = entity.Title,
//                        Description = entity.Description,
//                        Genre = entity.Genre,
//                        AverageRating = entity.AverageRating
//                    };
//            }
//        }
//        public IEnumerable<MovieListItem> GetMovieByGenre(GenreType genre)
//        {
//            using (var ctx = new ApplicationDbContext())
//            {
//                var query =
//                    ctx
//                        .Movies
//                        .Where(e => e.Genre == genre)//adjustment may be needed
//                        .Select(
//                            e =>
//                                new MovieListItem
//                                {
//                                    MovieId = e.MovieId,
//                                    Title = e.Title,
//                                    Description = e.Description,
//                                    AverageRating = e.AverageRating
//                                }
//                         );
//                return query.ToArray();
//            }
//        }
//    }
//}
