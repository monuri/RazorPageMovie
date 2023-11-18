using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPageMovie.Models
{
    public class Movie
    {

        public int Id { get; set; }
        //se usara el simbolo de interrogacion para indicar que el dato puede ir nulo 
        [StringLength(60,MinimumLength =3)]
        [Required]
        public string? Title { get; set; }
        // las etiquetas sirven para dar formato a los tipos de datos
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; }
        [Column(TypeName ="decimal(18,2)")]
        [Range(1,100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        public string? Rating  { get; set; }
    }
}
