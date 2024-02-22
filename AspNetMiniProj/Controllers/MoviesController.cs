using AspNetMiniProj.Models;
using AspNetMiniProj.Views.Movies;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMiniProj.Controllers
{
    public class MoviesController : Controller
    {

        DataService dataService;

        public MoviesController(DataService dataService) 
        { 
            this.dataService = dataService;  
        }
        
        
        [HttpGet("")]
        public IActionResult Index()
        {
            var model = dataService.GetAllMovies()
                .Select(x => new IndexVM
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                })
                .ToArray();
                
                
            return View(model);
        }

        [HttpGet("/detail/{Id}")]
        public IActionResult Detail(int id)
        {

            var movie = dataService.GetMovieById(id);
            var model = new DetailVM
            {
                Id = movie.Id,
                Name = movie.Name,
                Description = movie.Description,
            };
            return View(model);

        }

        [HttpPost("create")]
        public IActionResult Create(CreateVM movie)
        {
            dataService.AddMovie(movie);
            return RedirectToAction(nameof(Index));

        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }


    }

}
