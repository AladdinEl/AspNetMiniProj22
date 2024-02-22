using System.ComponentModel.DataAnnotations;

namespace AspNetMiniProj.Views.Movies
{
    public class CreateVM
    {
        [Required(ErrorMessage = "The Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Description is required")]
        public string Description { get; set; }

    }
}
