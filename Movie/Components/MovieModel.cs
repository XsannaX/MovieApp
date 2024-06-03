using System.ComponentModel.DataAnnotations;

namespace Movie.Components
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateOnly? RelaseDate { get; set; }
        [Range(1.00, 10.00, ErrorMessage = "Rating must be between 1 and 10")]
        public float? Rate { get; set; }
        public string? Poster { get; set; }
    }
}
