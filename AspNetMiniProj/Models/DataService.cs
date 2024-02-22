using AspNetMiniProj.Views.Movies;

namespace AspNetMiniProj.Models
{
    public class DataService
    {
     

        private readonly ApplicationContext context;

        public DataService(ApplicationContext context)
        {
            this.context = context;
        }

        public IndexVM[] GetAllMovies()
        {
            return context.Movies
                .OrderBy(x => x.Name)
                .Select(x=> new IndexVM
                {

                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                })
 
                .ToArray();
        }

        public DetailVM? GetMovieById(int id)
        {
            return context.Movies
                .Where(x => x.Id == id)
                .Select(x => new DetailVM
                   {

                       Id = x.Id,
                       Name = x.Name,
                       Description = x.Description,
                   })
                   .SingleOrDefault();
        }

        public void AddMovie(CreateVM movie)
        {
            context.Movies.Add(new Movie
            {
                Name = movie.Name,
                Description = movie.Description,
            });

                
            context.SaveChanges();

        }


    }
}
