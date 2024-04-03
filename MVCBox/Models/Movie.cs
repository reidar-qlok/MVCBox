using System.ComponentModel.DataAnnotations;

namespace MVCBox.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage = "Description is requiered")]
        public string MovieDescription { get; set; }
    }
}
